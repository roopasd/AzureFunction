#r "Microsoft.WindowsAzure.Storage"            //For framework assemblies, add references by using the #r "AssemblyName" directive.

using Microsoft.WindowsAzure.Storage.Blob;
using System.IO;

public static async void Run(CloudBlockBlob myBlob, string blobFileName, CloudBlockBlob outputBlob, ILogger log)
{
    log.LogInformation($"C# Blob trigger function Processed blob\n Name:{blobFileName} ");
  
    using (var stream = await myBlob.OpenReadAsync())
    {
       await  outputBlob.UploadFromStreamAsync(stream);
    }
}
