using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using OuroFramework.Application;
using System;
using System.IO;

namespace ServiceHost
{
    public class FileUploader : IFileUploader
    {
        private readonly IWebHostEnvironment _webHostEnvironment;
        public FileUploader(IWebHostEnvironment webHostEnvironment)
        {
            _webHostEnvironment = webHostEnvironment;
        }

        public string Upload(IFormFile file, string category)
        {
            if(file is null) return "";
            string directoryPath = $"{_webHostEnvironment.WebRootPath}/Images/{category}";
            if (!Directory.Exists(directoryPath))
                Directory.CreateDirectory(directoryPath);

            string fileName = $"{DateTime.Now.ToFileName()}-{file.FileName}";
            string path = $"{directoryPath}/{fileName}";
            using (var stream = File.Create(path))
            {
                file.CopyTo(stream);
            }
            return $"{category}/{fileName}";
        }
    }
}
