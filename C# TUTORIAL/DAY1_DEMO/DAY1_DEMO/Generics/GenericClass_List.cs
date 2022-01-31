using System;
using System.Collections.Generic;

public class GenericClasses
{
    static void fn(String[] arg)
    {   
        var names = new List<string>();
        names.Add("Tushar");
        names.Add("Nikhil");
        names.Add("Max");
        names.Add("Hudiram");
        Console.WriteLine($"Name = {names[0]} Count = {names.Count}");
        foreach (var name in names)
        {
            Console.WriteLine(name);

        }

    } 
    }
