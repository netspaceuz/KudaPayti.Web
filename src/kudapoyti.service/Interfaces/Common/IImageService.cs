using Microsoft.AspNetCore.Http;

namespace kudapoyti.Service.Interfaces.Common
{
    public interface IImageService
    {
        public Task<string> SaveImageAsync(IFormFile file);
        public Task<bool> DeleteImageAsync(string imagePath);
    }
}
