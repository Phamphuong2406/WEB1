namespace Web1.Service
{
    public interface IUploadFileService
    {
        Task<string> SaveFile(IFormFile file, string directory, string[] allowedExtensions);
        void DeleteFile(string fileName, string directory);
    }
    public class UploadFileService : IUploadFileService
    {
        private readonly IWebHostEnvironment _webHostEnvironment;
        public UploadFileService(IWebHostEnvironment webHostEnvironment)
        {
            _webHostEnvironment = webHostEnvironment;
        }
        public async Task<string> SaveFile(IFormFile file, string directory, string[] allowedExtensions)
        {
            var wwwPath = _webHostEnvironment.WebRootPath;
            var path = Path.Combine(wwwPath, directory);

            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }

            var extension = Path.GetExtension(file.FileName);
            if (!allowedExtensions.Contains(extension))
            {
                throw new InvalidOperationException($"Only {string.Join(",", allowedExtensions)} extensions are allowed");
            }

            var newFileName = $"{Guid.NewGuid()}{extension}";
            var fullPath = Path.Combine(path, newFileName);

            using var fileStream = new FileStream(fullPath, FileMode.Create);
            await file.CopyToAsync(fileStream); // ✅ Đã await

            return newFileName;
        }

        /*  public void DeleteFile(string fileName, string directory)
          {
              var fullPath = Path.Combine(_webHostEnvironment.WebRootPath, directory, fileName);
              if (!Path.Exists(fullPath))
              {
                  throw new FileNotFoundException($"File {fileName} does not exists");
              }
              File.Delete(fullPath);
          }*/
        /*public void DeleteFile(string fileName, string directory)
        {
            var fullPath = Path.Combine(_webHostEnvironment.WebRootPath, directory, fileName);

            if (!File.Exists(fullPath))
            {
                throw new FileNotFoundException($"File {fileName} does not exists");
            }

            File.Delete(fullPath);
        }*/
        public void DeleteFile(string fileName, string directory)
        {
            var fullPath = Path.Combine(_webHostEnvironment.WebRootPath, directory, fileName);

            if (File.Exists(fullPath))
            {
                File.Delete(fullPath);
            }
            // Ngược lại, không làm gì cả
        }


    }
}
