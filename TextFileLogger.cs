using System;
using System.IO;

namespace _2dWorldApp
{
    public class TextFileLogger : ILogger
    {
        private const string DirectoryName = @"C:\Users\Monika Petkova\Desktop\text";
        private readonly string FileName = "Text.txt";

        public void WriteLine(string message)
        {
            using (StreamWriter outputFile = File.AppendText(Path.Combine(DirectoryName, FileName)))
            {
                outputFile.WriteLine(message);
            }
        }
        public void DisplayLog()
        {
            try
            {
                // Open the text file using a stream reader.
                using (var sr = new StreamReader(DirectoryName + FileName))
                {
                    // Read the stream to a string, and write the string to the console.
                    while (!sr.EndOfStream)
                    {
                        Console.WriteLine(sr.ReadLine());
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }
        }
    }
}
