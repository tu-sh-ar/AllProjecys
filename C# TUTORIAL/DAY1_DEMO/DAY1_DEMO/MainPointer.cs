using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainPtr
{
    public class MainPointer
    {   
        
        public static void UpdatePtr(string Fname) { 
            using(TextWriter writer = new StreamWriter(File.Open("D:\\C# TUTORIAL\\DAY1_DEMO\\DAY1_DEMO/MainPointer.txt", FileMode.Open))) { 
                writer.WriteLine("                                               ");
                writer.WriteLine("Current Pointer -> {0}",Fname);
            
            }
        
        }
    }
}
