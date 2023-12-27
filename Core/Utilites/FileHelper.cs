using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Core.Utilites
{
    public class FileHelper
    {
        static string directory = Directory.GetCurrentDirectory() + @"\wwwroot\";    // Uygulamanın çalışma dizinini elde ederiz.
        static string path = @"Images\";        // Çalışma dizinine ekleyeceğimiz  klasör.

        public static string Add(IFormFile file)
        {
            string extension = Path.GetExtension(file.FileName);   // dosya uzantısını aldık.
            string newFileName = Guid.NewGuid().ToString("N") + extension;  // 32 karakterli bir dosya oluşturduk.

            if (!Directory.Exists(directory + path))
            {
                Directory.CreateDirectory(directory + path);
            }

            using (FileStream fileStream = File.Create(directory + path + newFileName))
            {
                file.CopyTo(fileStream);
                fileStream.Flush();
            }
            return (path + newFileName).Replace("\\", "/");
        }



        public static void Delete(string imagePath)
        {
            if (File.Exists(directory + imagePath.Replace("/", "\\")) && Path.GetFileName(imagePath) != "image.bmp")
            {
                File.Delete(directory + imagePath.Replace("/", "\\"));
            }
        }


        public static string Update(IFormFile file, string oldImagePath)
        {
            Delete(oldImagePath);
            return Add(file);


        }


    }
}
