using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BinaryWriter_Class
{
    class Program
    {
        static void Fn(string[] args)
        {
            using (BinaryWriter writer = new BinaryWriter(File.Open("D:\\C# TUTORIAL\\DAY1_DEMO\\DAY1_DEMO/binaryfile.bin", FileMode.Create)))
            {
                //Writting Error Log
                writer.Write("0x80234400");
                writer.Write("Windows Explorer Has Stopped Working");
                writer.Write(true);
            }
            Console.WriteLine("Binary File Created!");
            Console.ReadKey();
        }
    }
}