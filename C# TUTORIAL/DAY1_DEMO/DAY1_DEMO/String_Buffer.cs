using System.Text;

class String_Buffer
{
    static void Fn()
    {
        StringBuilder stringBuilder = new StringBuilder("hello");
        stringBuilder.Append(" From Strng builder");
        Console.WriteLine(stringBuilder);
        stringBuilder.AppendLine(" This is a line");
        stringBuilder.AppendLine(" This is another line");
        stringBuilder.AppendLine(" This is another of the another line");
        Console.WriteLine(stringBuilder);
        StreamReader sr = new StreamReader(File.Open(@"D:\C# TUTORIAL\DAY1_DEMO\DAY1_DEMO\new.txt", FileMode.Open));
        StringWriter stringWriter = new StringWriter(stringBuilder);
        sr.Close();
        stringWriter.Close();
        Console.WriteLine(sr.ReadToEnd());
    }
}