using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Flac2WMA
{
    internal class Album
    {
        public string FilePath { get; private set; }

        public Album(string filePath)
        {
            FilePath = filePath;
            LoadInfo();
        }

        public string Artist { get; internal set; }

        public string Title { get; internal set; }

        public string Genre { get; internal set; }

        public int Year { get; internal set; }

        public void LoadInfo()
        {
            string cueSheetPath =
                System.IO.Path.Combine(System.IO.Path.GetDirectoryName(FilePath), System.IO.Path.GetFileNameWithoutExtension(FilePath) + ".cue");

            var reader = System.IO.File.OpenText(cueSheetPath);
            try
            {
                string line = reader.ReadLine();
                while (line != null)
                {
                    if (line.StartsWith("FILE ")) break;

                    string[] words = line.Split(new[] { ' ' }, 3);
                    switch (words[0])
                    {
                        case "REM":
                            switch (words[1])
                            {
                                case "GENRE":
                                    Genre = line.Substring(10);
                                    break;
                                case "DATE":
                                    Year = int.Parse(line.Substring(9));
                                    break;
                            }
                            break;
                        case "PERFORMER":
                            Artist = line.Substring(11, line.Length - 12);
                            break;
                        case "TITLE":
                            Title = line.Substring(7, line.Length - 8);
                            break;
                    }

                    line = reader.ReadLine();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Unable to read through file.", ex);
            }
            finally
            {
                reader.Close();
            }
        }

    }
}