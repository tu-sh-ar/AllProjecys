using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BinaryReader_Class
{
    class Program
    {
        static void MainFn(string[] args)
        {
            WriteBinaryFile();
            ReadBinaryFile();
            Console.ReadKey();
        }
        static void WriteBinaryFile()
        {
            using (BinaryWriter writer = new BinaryWriter(File.Open("D:\\binaryfile2.bin", FileMode.Create)))
            {
                //Writting Error Log
                writer.Write("0x80234400");
                writer.Write("Windows Explorer Has Stopped Working");
                writer.Write(true);
            }
        }
        static void ReadBinaryFile()
        {
            using (BinaryReader reader = new BinaryReader(File.Open("D:\\binaryfile2.bin", FileMode.Open)))
            {
                Console.WriteLine("Error Code: {0}",reader.ReadString());
                Console.WriteLine("Error Message: {0}",reader.ReadString());
                Console.WriteLine("Reset System: {0}",reader.ReadBoolean());
            }
        }
    }
}