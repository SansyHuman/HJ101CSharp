using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSeminar3
{
    public enum Option
    {
        None,
        Read,
        Write = 3,
        ReadWrite
    }

    class EnumTest
    {
        public static void TestEnum()
        {
            Console.WriteLine(Option.None);
            Console.WriteLine(Option.Read);
            Console.WriteLine(Option.Write);
            Console.WriteLine(Option.ReadWrite);

            Console.WriteLine((int)Option.None);
            Console.WriteLine((int)Option.Read);
            Console.WriteLine((int)Option.Write);
            Console.WriteLine((int)Option.ReadWrite);

            Option option = Option.Read;

            switch (option)
            {
                case Option.None:
                    Console.WriteLine("None");
                    break;
                case Option.Read:
                    Console.WriteLine("Read");
                    break;
                case Option.Write:
                    Console.WriteLine("Write");
                    break;
                case Option.ReadWrite:
                    Console.WriteLine("ReadWrite");
                    break;
            }
        }
    }
}
