using System;
using System.Net;
using System.IO.Compression;
using System.IO;

namespace bonkersland_client_downloader_XD
{
    class Program
    {
        static void Main(string[] args)
        {
            string extractionPath = @"C:\Bonkersland";
            string version = "v1.0";
            Console.Title = "Bonkersland Client Downloader";
            Console.WriteLine("Bonkersland client downloader version "+ version);
            Console.WriteLine("Press any key to start downloading...");
            Console.WriteLine("\nIf you pressed a key and it didn't do anything, just wait. There is a small delay for some reason (i didn't add it)\n");
            Console.WriteLine("WARNING: If the "+ extractionPath + " folder has files in it, delete all of them. If you don't then it will give you an error.");
            Console.ReadKey();
            Console.WriteLine("\nDownloading client file from website...");
            // download the client from the website
            using (var client = new WebClient())
            {
                client.DownloadFile("http://bonkers.tk/clients/BonkerslandClient.zip", "BonkerslandClient.zip");
            }

            // create the bonkersland folder

            Console.WriteLine("Preparing extraction...");
            string dir = @"C:\Bonkersland";
            if (!Directory.Exists(dir))
            {
                Directory.CreateDirectory(dir);
            }

            // extract file

            Console.WriteLine("Extracting file...");
            string zipFilePath = @"BonkerslandClient.zip";
            ZipFile.ExtractToDirectory(zipFilePath, extractionPath);

            Console.WriteLine("Clearing temporary files...");

            File.Delete(@"BonkerslandClient.zip");

            Console.Clear();
            Console.WriteLine("Bonkersland is successfully downloaded to your computer!!!!!!! The client directory is "+ extractionPath +". Press any key to quit. (again, this also has a delay and i didn't add it)");
            Console.ReadKey();

        }
    }
}

// made by troll212420
// this entire code is not made by me, i used stack overflow and a few more sites
