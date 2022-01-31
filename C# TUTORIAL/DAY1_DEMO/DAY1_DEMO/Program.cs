using System;




//namespace CSharpTutorials
//{
    class Program
    {
        static void Test(string[] args)

        {
            //string message = "Write your msg";

            //Console.WriteLine(message);
            //Console.WriteLine(Console.ReadLine());

            //Data Types 
            
                //Reference type 
            
            //byte a = 255;
            //sbyte b = -122;
            //short s = 122;
            //ushort u = 0;
            //int i = 0;
            //uint ui = 0;
            //long l = 0;
            //ulong r = 0;
            //char c = 'a';
            //float f = 134543534656547756867656255422155255.5f;
            //double d = 0.0D;
            //decimal dc = 11M;
            //bool val = false;
            
                //value type
            //string str = "String can contain 2 billion characters";
            
                //multiple var in single line
            //int k,
              //  j = 9, k2 = 8;

            //var can be used to declare methd level variables
//                var x = 78;

            //implicitly declared variable
            var y = "hello";
            var z = 91;
                
            Console.WriteLine(y.GetType()); //returns type with parent class eg- System.string
            Console.WriteLine(y.GetTypeCode());//returns tyep with code only eg- String
            //Console.WriteLine(y.First());
            //Console.WriteLine(y.Last());
            Console.WriteLine(z.ToString(y));

            //Console.WriteLine(a);

//            STRING.FORMAT
               //Formats an object, you specify the formatting you wish to perform, the following formats an
                //integer and displays the currency symbol. 
                //EXAMPLE
            Console.WriteLine(string.Format("{0}", 61));
            System.Console.WriteLine("Writing With System.Console");
            //Console.WriteLine(args[0]);

        }
    }
//}

