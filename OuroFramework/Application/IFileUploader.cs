using Microsoft.AspNetCore.Http;

namespace OuroFramework.Application
{
    public interface IFileUploader
    {
        string Upload(IFormFile file, string category);
    }
}
