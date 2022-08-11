using Azure.Storage.Blobs;
using System;

// Note: actual namespace depends on the project name.
    public class Program
    {
        private static string containerName = "data1";
        
        private static string connectionString = "";

        private static string blobName = "ICMone.txt";

        private static string locationOfFile = "C:\\Users\\dipeshjadhav\\Desktop\\ICMone.txt";

        static void Main(string[] args)
        {
            BlobServiceClient blobServiceClient = new BlobServiceClient(connectionString);

         

            BlobContainerClient containerClient = blobServiceClient.GetBlobContainerClient(containerName);
            
        if(!containerClient.Exists())
        {
            blobServiceClient.CreateBlobContainer(containerName);
        }

             BlobClient blobClient = containerClient.GetBlobClient(blobName);

            blobClient.Upload(locationOfFile);
            Console.WriteLine("blob uploaded");

             Console.ReadKey();
        }
    }