using System;
using System.Collections.Generic;

public class LinkedLists
{
    static void fn(String[] arg)
    {
        var names = new LinkedList<string>();
        
        //Console.WriteLine($"Name = {names[0]} Count = {names.Count}");
        for(int i=0;i<10;i++)
        {
            names.AddFirst(i.ToString());

        }
        names.Remove("2");
        foreach(string i in names)
        {
            Console.WriteLine(i);
        }

    }
}
