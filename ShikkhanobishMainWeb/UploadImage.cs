using System;
using System.Collections.Generic;
using System.Linq;
using Google.Cloud.Storage.V1;
using System.IO;
using Google.Apis.Auth.OAuth2;
using System.Threading.Tasks;

namespace ShikkhanobishMainWeb
{
    public class UploadImage
    {
        // Some APIs, like Storage, accept a credential in their Create()
        // method.
        public object AuthExplicit(string projectId, string jsonPath)
        {
            // Explicitly use service account credentials by specifying
            // the private key file.
            var credential = GoogleCredential.FromFile(jsonPath);
            var storage = StorageClient.Create(credential);
            // Make an authenticated API request.
            var buckets = storage.ListBuckets(projectId);

            return null;
        }

        public string UploadFileSample(string bucketName, string localPath)
        {
            AuthExplicit("enhanced-emblem-234505", "wwwroot/GoogleKeyFile/enhanced-emblem-234505-8ede9bde9f07.json");
            bucketName = "shlivesupportimage";
            localPath = "E:/Shikkhanobish/blacklogo.png";
            string objectName = generateID(localPath)  ;
            var storage = StorageClient.Create();
            using var fileStream = File.OpenRead(localPath);
            storage.UploadObject(bucketName, objectName, null, fileStream);           
            return "https://storage.cloud.google.com/"+ bucketName+"/"+ objectName;
        }
        public string generateID(string sourceUrl)
        {
            return string.Format("{0}_{1:N}", sourceUrl, Guid.NewGuid());
        }
    }
}
