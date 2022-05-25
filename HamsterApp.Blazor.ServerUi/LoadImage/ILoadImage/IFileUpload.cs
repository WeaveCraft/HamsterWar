using Microsoft.AspNetCore.Components.Forms;

namespace HamsterApp.Blazor.ServerUi.LoadImage.ILoadImage
{
    public interface IFileUpload
    {
        Task<string> UploadFile(IBrowserFile file);

        bool DeleteFile(string filePath);
    }
}
