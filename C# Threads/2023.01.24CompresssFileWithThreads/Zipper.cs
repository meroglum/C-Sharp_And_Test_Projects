using System;
using System.Collections.Generic;
using System.IO.Compression;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _2023._01._24CompresssFileWithThreads
{
    /// <summary>
    /// IMPORTANT
    /// To use this app apropriate file paths must be given acoording to the local computer.
    /// Otherwise it will probably crash.
    /// </summary>
    /// <param name="args"></param>
    public class Zipper
    {
        int i = 0;

        /// <summary>
        /// To .zip and unzip the file.
        /// </summary>
        public async void CompressAndDecompressFile()
        {
            // Change these string so that it will be appropriate for the current pc.
            string startPath = "C:/Users/Z004PUCE/OneDrive - Siemens AG/Desktop/Notlar/project files/2023.01.24CompressingWithThreads/dataToBeZipped";
            string zipPath = "C:/Users/Z004PUCE/OneDrive - Siemens AG/Desktop/Notlar/project files/2023.01.24CompressingWithThreads/ZippedData/result.zip";
            string extractPath = "C:/Users/Z004PUCE/OneDrive - Siemens AG/Desktop/Notlar/project files/2023.01.24CompressingWithThreads/ExtractedZip";

            ZipFile.CreateFromDirectory(startPath, zipPath);
            Console.WriteLine("File is compressing....");
            Console.WriteLine("File is decompressing...");
            ZipFile.ExtractToDirectory(zipPath, extractPath);
            Console.WriteLine("İslem basariyla tamamlamlandı.");
        }

        /// <summary>
        /// it will get the passed time in seconds while the extract and compress proccess is ongoing.
        /// </summary>
        public void GetPassedTime()
        {
            Console.WriteLine("Geçen süre {0} saniye", + i);
            i++;
            Thread.Sleep(1000); // time in ms.
        }
    }
}
