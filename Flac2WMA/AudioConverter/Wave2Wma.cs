using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Expression.Encoder;
using System.IO;
using System.Reflection;
using System.Xml;

namespace AudioConverter
{
    public class Wave2Wma
    {
        public static bool ConvertWave2Wma(string waveFilePath, string artist, string title, string genre, int year, out string exceptionMessage)
        {
            //encode
            MediaItem albumItem;
            try
            {
                string jobFilePath = waveFilePath.Replace(".wav", "-job.xej");

                StreamReader reader = new StreamReader(Assembly.GetExecutingAssembly().GetManifestResourceStream("AudioConverter.ExpressionEncoderJob.xej"));
                File.WriteAllText(jobFilePath, reader.ReadToEnd());
                reader.Close();

                Job job = Job.LoadJob(jobFilePath);

                string presetFilePath = waveFilePath.Replace(".wav", "-presets.xml");
                WritePresetFile(presetFilePath, artist, title, genre, year);
                job.MediaItems.Clear();
                albumItem = new MediaItem(waveFilePath);
                job.MediaItems.Add(albumItem);
                job.ApplyPreset(Preset.FromFile(presetFilePath));
                job.Encode();
                exceptionMessage = null;
                return true;
            }
            catch (Exception ex)
            {
                exceptionMessage = ex.Message;
                return false;
            }
        }

        private static void WritePresetFile(string presetFilePath, string artist, string title, string genre, int year)
        {
            XmlDocument doc = new XmlDocument();
            StreamReader reader = new StreamReader(Assembly.GetExecutingAssembly().GetManifestResourceStream("AudioConverter.ExpressionEncoderJobPresets.xml"));
            try
            {
                doc.LoadXml(reader.ReadToEnd());
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                reader.Close();
            }

            XmlElement metadata = (XmlElement)doc.SelectSingleNode("/Preset/MediaFile/Metadata");
            metadata.SelectSingleNode("Item[@Name = 'WM/AlbumArtist']/@Value").InnerText = artist;
            metadata.SelectSingleNode("Item[@Name = 'WM/AlbumTitle']/@Value").InnerText = title;
            metadata.SelectSingleNode("Item[@Name = 'WM/Genre']/@Value").InnerText = genre;
            metadata.SelectSingleNode("Item[@Name = 'WM/Year']/@Value").InnerText = year.ToString();
            doc.Save(presetFilePath);
        }
    }
}
