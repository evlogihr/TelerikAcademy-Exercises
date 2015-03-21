using System;
using System.Collections.Generic;
using System.Linq;

using GenericClass.Models;

namespace GenericClass
{
    public class Program
    {
        static void Main()
        {
            var list = new GenericList<int>(5);
            list.Add(5);
            list.Add(10);
            list.Add(20);

            list.Insert(1, 123);

            list.Add(-100);

            Console.WriteLine(list);

            Console.WriteLine(list.Min());
            Console.WriteLine(list.Max());
        }
    }
}
