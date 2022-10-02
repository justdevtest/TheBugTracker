using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using TheBugTracker.Services.Interfaces;

namespace TheBugTracker.Services
{
    public class BTFileService : IBTFileService
    {
        private readonly string[] suffixes = { "Bytes", "KB", "MB", "GB", "TB", "PB" };

        public string ConvertByteArrayToFile(byte[] fileData, string extension)
        {
            try
            {
                string imageBase64Data = Convert.ToBase64String(fileData);
                return string.Format($"data:{extension};base64,{imageBase64Data}");
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<byte[]> ConvertFileToByteArrayAsync(IFormFile file)
        {
            try
            {
                // Create the stream to store the file
                MemoryStream memoryStream = new();

                // Copy the file data to the stream
                await file.CopyToAsync(memoryStream);

                // Convert to byte array
                byte[] byteFile = memoryStream.ToArray();

                //Clean up memory stream (deliberately)
                memoryStream.Close();
                memoryStream.Dispose();

                return byteFile;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public string FormatFileSize(long bytes)
        {
            int counter = 0;
            decimal fileSize = bytes;

            while (Math.Round(fileSize / 1024) >= 1)
            {
                fileSize /= bytes;
                counter++;
            }
            return string.Format("{0:n1},{1}", fileSize, suffixes[counter]);
        }

        public string GetFileIcon(string file)
        {
            string fileImage = "default";

            if (!string.IsNullOrWhiteSpace(file))
            {
                fileImage = Path.GetExtension(file).Replace(".", "");
                return $"/img/contentType/{fileImage}.png";
            }
            return fileImage;
        }
    }
}
