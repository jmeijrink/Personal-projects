using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AudioConverter
{
    public class Flac2Wave
    {
        public static bool ConvertFlac2Wave(string flacFilePath, string waveFileOutputPath, out string error)
        {
            try
            {

                //C:\Program Files (x86)\Exact Audio Copy\Flac>flac -d "C:\temp\The Sunclub - Fiesta de los tamborileros (The Jaydee Remix).flac" C:\temp\test.wav
                var flacProc = new System.Diagnostics.Process();
                flacProc.StartInfo.WorkingDirectory = @"C:\Program Files (x86)\Exact Audio Copy\Flac";
                flacProc.StartInfo.FileName = "flac.exe";
                flacProc.StartInfo.Arguments = string.Format(" -d \"{0}\" \"{1}\"", flacFilePath, waveFileOutputPath);
                flacProc.Start();
                flacProc.WaitForExit();
                error = null;
                return true;
            }
            catch (Exception ex)
            {
                error = ex.Message;
                return false;
            }
        }

    }
}
