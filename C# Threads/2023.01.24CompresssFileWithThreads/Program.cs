using _2023._01._24CompresssFileWithThreads;
using System.IO.Compression;
using System.Reflection;

/// <summary>
/// Created By Muhammed EROGLU
/// </summary>
internal class Program
{
    /// <summary>
    // IMPORTANT
    /// To use this app apropriate file paths must be given acoording to the local computer.
    /// Otherwise it will probably crash. Zipper.cs can be observed.
    /// </summary>
    /// <param name="args"></param>
    private static void Main(string[] args)
    {
        // Threads and methods to compress and decompress the file.
        Zipper zipper = new Zipper();
        Thread zipperThread = new Thread(new ThreadStart(zipper.CompressAndDecompressFile));
        Thread zipperCountThread = new Thread(new ThreadStart(zipper.GetPassedTime));
        zipperThread.IsBackground = true;
        zipperCountThread.IsBackground = true; 
        zipperThread.Start();
        zipperCountThread.Start();
       
        // Calculates passed time in the console.
        while (zipperThread.IsAlive)
        {
            zipper.GetPassedTime();
        }

        /// After the job is done close the threads.
        zipperThread.Abort();
        zipperCountThread.Abort();
        
    }
}