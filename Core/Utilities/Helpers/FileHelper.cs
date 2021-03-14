using Microsoft.AspNetCore.Http;
using System;
using System.IO;
using Core.Utilities.Results;

namespace Core.Utilities.Helpers
{
    public class FileHelper
    {
        public static string Add(IFormFile image)
        {
            var sourcePath = Path.GetTempFileName();
            if (image.Length > 0)
            {
                using (var stream = new FileStream(sourcePath, FileMode.Create))
                {
                    image.CopyTo(stream);
                }
            }
            var result = newPath(image);
            File.Move(sourcePath, result);
            return result;
        }

        public static IResult Delete(string path)
        {
            try
            {
                File.Delete(path);
            }
            catch (Exception e)
            {
                return new ErrorResult(e.Message);
            }

            return new SuccessResult();
        }

        public static string Update(string sourcePath, IFormFile image)
        {
            var result = newPath(image);
            if (sourcePath.Length > 0)
            {
                using (var stream = new FileStream(result, FileMode.Create))
                {
                    image.CopyTo(stream);
                }
            }
            File.Delete(sourcePath);
            return result;
        }

        public static string newPath(IFormFile image)
        {
            FileInfo fileInfo = new FileInfo(image.FileName);
            string fileExtension = fileInfo.Extension;

            string path = Environment.CurrentDirectory + @"\wwwroot\Images";
            var newPath = Guid.NewGuid().ToString() + "_" + DateTime.Now.Month + "_" + DateTime.Now.Day + "_" + DateTime.Now.Year + "_" + fileExtension;

            string result = $@"{path}\{newPath}";
            return result;
        }
    }
}
