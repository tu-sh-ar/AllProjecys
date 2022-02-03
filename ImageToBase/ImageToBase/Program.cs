using System.IO;


using Newtonsoft.Json.Linq;
using System.Drawing.Imaging;

//USED REFERENCE https://stackoverflow.com/questions/21325661/convert-an-image-selected-by-path-to-base64-string


namespace ImageToBase {
    class Program
    {
        static void Main(string[] args)
        {
            const string FilePath = @"C:\Users\PC\source\repos\AllProjecys\ImageToBase\ImageToBase\TextFile1.txt";
            string fileData;
            using(File.OpenRead(FilePath))
            {
                fileData = File.ReadAllText(FilePath);
            }
            Base64ToImage(fileData);
        }

        public static void Base64ToImage(string base64String)
        {
            // Convert base 64 string to byte[]
            byte[] imageBytes = Convert.FromBase64String(base64String);
            var image = File.OpenWrite(@"C:\Users\PC\source\repos\AllProjecys\ImageToBase\ImageToBase\Image.png");


            // Convert byte[] to Image
            
                image.Write(imageBytes);
                image.Close();
            
        }

    }

}