using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAY1_DEMO
{
    internal class FileHandling1
    {
        static void Fn()
        {
            
            var filePath = @"D:\C# TUTORIAL\DAY1_DEMO\DAY1_DEMO\"; 
            String fileName = "new.txt";
            
            //Check if file exists
            Console.WriteLine(File.Exists(Path.Combine(filePath,fileName)));
            Console.WriteLine(File.ReadAllText(System.IO.Path.Combine(filePath,fileName)));

            //Directories
            System.IO.Directory.Exists(filePath);
            System.IO.Directory.CreateDirectory(filePath+"Dummy");
            Console.WriteLine(System.IO.Directory.GetParent(filePath));
            System.IO.Directory.Delete(filePath+"Dummy");
            

        }
    }
}
