public class AllGenerics
{
    static void fn(String[] arg)
    {
        var sorted_list = new SortedList<Int16, Int16>();
        var hashset = new HashSet<string>();
        var dict = new Dictionary<Int16, string>();
        var sorted_set = new SortedSet<Int16>();

        sorted_list.Add(0, 21);
        hashset.Add("hello");
        dict.Add(1, "tushar");
        sorted_set.Add(1);

        //Console.WriteLine($"Name = {names[0]} Count = {names.Count}");

    }
}
