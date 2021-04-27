using System;

namespace HW3
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList(10);

            Console.WriteLine($"List length: {list.Length}");

            list.SetAt(0, "Hello world!");
            list.SetAt(3, "HAJE forever");

            Console.WriteLine(list.GetAt(0));
            Console.WriteLine(list.GetAt(3));
            Console.WriteLine(list.GetAt(13) == null);
            Console.WriteLine(list.GetAt(2) == null);
        }
    }
}
