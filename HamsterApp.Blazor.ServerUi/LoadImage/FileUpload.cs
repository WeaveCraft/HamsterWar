using HamsterApp.Blazor.ServerUi.LoadImage.ILoadImage;
using Microsoft.AspNetCore.Components.Forms;

namespace HamsterApp.Blazor.ServerUi.LoadImage
{
    public class FileUpload : IFileUpload
    {
        private readonly IWebHostEnvironment _webHostEnvironment;

        public FileUpload(IWebHostEnvironment webHostEnvironment)
        {
            _webHostEnvironment = webHostEnvironment;
        }

        public bool DeleteFile(string filePath)
        {
            if (File.Exists(_webHostEnvironment.WebRootPath + filePath))
            {
                File.Delete(_webHostEnvironment.WebRootPath + filePath);
                return true;
            }
            return false;
        }

        public async Task<string> UploadFile(IBrowserFile file)
        {
            FileInfo fileInfo = new FileInfo(file.Name);
            var fileName = Guid.NewGuid().ToString()+fileInfo.Extension;
            var folderDirectory = $"{_webHostEnvironment.WebRootPath}\\images";
            if (!Directory.Exists(folderDirectory)) //if images folder does not exist we will create it.
            {
                Directory.CreateDirectory(folderDirectory);
            } //And then we want to create our files.
            var filePath = Path.Combine(folderDirectory, fileName);

            await using FileStream fs = new FileStream(filePath, FileMode.Create);
            await file.OpenReadStream().CopyToAsync(fs);

            var fullPath = $"/images/{fileName}";
            return fullPath;
        }
    }
}
