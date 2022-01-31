namespace DAY1_DEMO
{
    internal class FileHandling
    {
        static void Fn()
        {
            FileStream fs = new FileStream("D:\\C# TUTORIAL\\DAY1_DEMO\\DAY1_DEMO/new2.txt", FileMode.Create);
            fs.Close();
            Console.WriteLine("Successfully Created file");

            FileStream fileStream = new FileStream("D:\\C# TUTORIAL\\DAY1_DEMO\\DAY1_DEMO/new.txt", FileMode.Open, FileAccess.Read);
            using(StreamReader sr = new StreamReader(fileStream))
            {
                Console.WriteLine(sr.ReadToEnd()); 
            }

            FileStream fileStream1 = new FileStream("D:\\C# TUTORIAL\\DAY1_DEMO\\DAY1_DEMO/new.txt", FileMode.Append, FileAccess.Write);
            using (StreamWriter sr = new StreamWriter(fileStream1))
            {
                sr.WriteLine(" Hello Again");
            }
            

        }
    }
}
