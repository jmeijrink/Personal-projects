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

namespace Flac2WMA
{
    public partial class Form1 : Form
    {
        private const string _scratchPath = "C:\\temp";
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAnalyze_Click(object sender, EventArgs e)
        {
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
                if (item.Checked)
                {
                    // Copy
                    try
                    {
                        string flacFile = System.IO.Path.Combine(_scratchPath, System.IO.Path.GetFileName(item.Text));
                        System.IO.File.Copy(item.Text, flacFile);
                    }
                    catch (Exception ex)
                    {
                        SetResult(item, "Unable to copy file {0}: {1}", item.Text, 
                    }

                    // Decode
                    //C:\Program Files (x86)\Exact Audio Copy\Flac>flac -d "C:\temp\The Sunclub - Fiesta de los tamborileros (The Jaydee Remix).flac" C:\temp\test.wav
                    string waveFile = System.IO.Path.Combine(System.IO.Path.GetDirectoryName(flacFile), System.IO.Path.GetFileNameWithoutExtension(flacFile) + ".wav");
                    var flacProc = new System.Diagnostics.Process();
                    flacProc.StartInfo.WorkingDirectory = @"C:\Program Files (x86)\Exact Audio Copy\Flac";
                    flacProc.StartInfo.FileName = "flac.exe";
                    flacProc.StartInfo.Arguments = string.Format(" -d \"{0}\" \"{1}\"", flacFile, waveFile);
                    flacProc.Start();
                    flacProc.WaitForExit();
                                        
                    //encode
                    job.MediaItems.Clear();

                    MediaItem albumItem = new MediaItem(waveFile);
                    job.MediaItems.Add(albumItem);
                    job.ApplyPreset(Preset.FromFile(@"C:\temp\jobpreset1.xml"));
                    job.Encode();

                    //Add file properties
                    DSOFile.OleDocumentProperties dso = new DSOFile.OleDocumentProperties();
                    dso.Open(albumItem.ActualOutputFileFullPath, false, DSOFile.dsoFileOpenOptions.dsoOptionDefault);


                }
            }
        }

        private void SetResult(ListViewItem albumItem, string result)
        {
            albumItem.BackColor = Color.MediumVioletRed;
            switch (albumItem.SubItems.Count)
            {
                case 3:
                    albumItem.SubItems.Add(result);
                    break;
                case 4:
                    albumItem.SubItems[3].Text = result;
                    break;
            }
        }
    }
}
