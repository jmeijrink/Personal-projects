using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using Microsoft.Expression.Encoder;
using System.Xml;

namespace Flac2WMA
{
    public partial class Form1 : Form
    {
        private const string _scratchPath = "C:\\temp";
        private const string _presetFile = "jobpreset.xml";

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAnalyze_Click(object sender, EventArgs e)
        {
            lvFlacs.Items.Clear();
            foreach (string filePath in Directory.GetFiles(txtPath.Text, "*.flac", SearchOption.AllDirectories))
            {
                Album albumInfo = new Album(filePath);
                ListViewItem albumItem = lvFlacs.Items.Add(filePath);
                albumItem.SubItems.Add(albumInfo.Artist);
                albumItem.SubItems.Add(albumInfo.Title);
                albumItem.Tag = albumInfo;
            }
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            Job job = Job.LoadJob(System.IO.Path.Combine(_scratchPath, "wav2wma-lossless.xej"));
            job.OutputDirectory = _scratchPath;
            foreach (ListViewItem item in lvFlacs.Items)
            {
                if (item.Checked) PerformCopyAndConversion(job, item);
            }
        }

        private void PerformCopyAndConversion(Job job, ListViewItem item)
        {
            string sourceFilePath = item.Text;
            string sourceFolder = System.IO.Path.GetDirectoryName(sourceFilePath);
            string flacFileName = System.IO.Path.GetFileName(sourceFilePath);

            // Move
            string flacFilePath;
            try
            {
                flacFilePath = System.IO.Path.Combine(_scratchPath, flacFileName);
                System.IO.File.Move(sourceFilePath, flacFilePath);
            }
            catch (Exception ex)
            {
                SetResult(item, "Unable to copy file {0}: {1}", item.Text, ex.Message);
                return;
            }

            // Decode
            string waveFilePath = System.IO.Path.Combine(_scratchPath, System.IO.Path.GetFileNameWithoutExtension(flacFilePath) + ".wav");
            string exceptionMessage;
            if (!AudioConverter.Flac2Wave.ConvertFlac2Wave(flacFilePath, waveFilePath, out exceptionMessage))
            {
                SetResult(item, "Error while decoding {0}: {1}", item.Text, exceptionMessage);
                return;
            }

            Album albumInfo = (Album)item.Tag;
            if (!AudioConverter.Wave2Wma.ConvertWave2Wma(waveFilePath, albumInfo.Artist, albumInfo.Title, albumInfo.Genre, albumInfo.Year, out exceptionMessage))
            {
                SetResult(item, "Error while encoding {0}: {1}", waveFilePath, exceptionMessage);
                return;
            }

            // Move back to share
            try
            {
                string wmaFileName = System.IO.Path.GetFileNameWithoutExtension(flacFileName) + ".wma";

                flacFilePath = System.IO.Path.Combine(_scratchPath, System.IO.Path.GetFileName(item.Text));
                System.IO.File.Move(System.IO.Path.Combine(_scratchPath, wmaFileName), System.IO.Path.Combine(sourceFolder, wmaFileName));
            }
            catch (Exception ex)
            {
                SetResult(item, "Unable to move file back to share {0}: {1}", item.Text, ex.Message);
                return;
            }

            System.IO.File.Delete(flacFilePath);
            System.IO.File.Delete(waveFilePath);
            item.Checked = false;
            lvFlacs.Update();
        }



        private void SetResult(ListViewItem albumItem, string result, params string[] args)
        {
            albumItem.BackColor = Color.MediumVioletRed;
            switch (albumItem.SubItems.Count)
            {
                case 3:
                    albumItem.SubItems.Add(string.Format(result, args));
                    break;
                case 4:
                    albumItem.SubItems[3].Text = result;
                    break;
            }
        }
    }
}
