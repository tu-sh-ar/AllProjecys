using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAY1_DEMO
{
    internal class Streams
    {
        static void Fn()
        {
            
            
            FileStream filestream_image = new FileStream(@"D:\C# TUTORIAL\DAY1_DEMO\DAY1_DEMO/flag.jpg",FileMode.Open,FileAccess.Read);
            using(StreamReader sw = new StreamReader(filestream_image)) { Console.WriteLine(sw.ReadToEnd()); }
            filestream_image.Close();
            Console.WriteLine("\n\n\n\n-------------------------------Img-------------------------------------------\n\n\n");

            FileStream filestream_png = new FileStream(@"D:\C# TUTORIAL\DAY1_DEMO\DAY1_DEMO/Img.png", FileMode.Open, FileAccess.ReadWrite);
            using (BinaryReader binaryReader = new BinaryReader(filestream_png)) { Console.WriteLine(binaryReader.ReadUInt32()); }
            filestream_png.Close();
            //filestream_png.Dispose();
            //filestream_png.Flush();
            
            GC.Collect(); //Bad practice Prefer not tot call GC Explicitly
            

            FileStream filestream2_png = new FileStream("D:\\C# TUTORIAL\\DAY1_DEMO\\DAY1_DEMO/Img.png", FileMode.Open, FileAccess.ReadWrite);

            //using (BinaryWriter binaryWriter = new BinaryWriter(filestream2_png)) { binaryWriter.Write(101); }
            BinaryWriter binaryWriter = new BinaryWriter(filestream2_png);
            try
            {
                
                binaryWriter.Write(101);
            }
            catch (Exception ex) {
                Console.Error.WriteLine(ex.ToString());
                binaryWriter.Dispose();
            }

            filestream_png.Close();
            
            Console.WriteLine("\n\n\n\n----------------------------------Png----------------------------------------\n\n\n");

            //FileStream filestream_exe = new FileStream("D:\\C# TUTORIAL\\DAY1_DEMO\\DAY1_DEMO/flag.jpg", FileMode.Open, FileAccess.Read);
            //using (StreamReader sw = new StreamReader(filestream_exe)) { Console.WriteLine(sw.ReadToEnd()); }
            //filestream_exe.Close();
            
        }
    }
}
