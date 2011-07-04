using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Wave2WMA
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length != 5)
            {
                Console.WriteLine("Five parameters required:");
                Console.WriteLine(" - wave file path");
                Console.WriteLine(" - artist");
                Console.WriteLine(" - title");
                Console.WriteLine(" - genre");
                Console.WriteLine(" - year");
                Console.WriteLine();
                Console.WriteLine(@"Example: Wave2WMA ""c:\temp\song.wav"" ""Madonna"" ""Ray of light"" ""Pop"" 2005");

                return;
            }

            string exceptionMessage;
            if (!AudioConverter.Wave2Wma.ConvertWave2Wma(args[0], args[1], args[2], args[3], int.Parse(args[4]), out exceptionMessage))
            {
                Console.WriteLine("Error: " + exceptionMessage);
            }
            else
            {
                Console.WriteLine("Done!");
            }
         }
    }
}
