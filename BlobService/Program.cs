using Azure.Storage.Blobs;
using System;

// Note: actual namespace depends on the project name.
    public class Program
    {
        private static string containerName = "data";
        private static string connectionString = "";
        

        static void Main(string[] args)
        {
            BlobServiceClient blobServiceClient = new BlobServiceClient(connectionString);

             blobServiceClient.CreateBlobContainer(containerName);


            Console.WriteLine("Container Created");

             Console.ReadKey();
        }
    }