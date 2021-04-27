using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSeminar4
{
    public class ArrayListV2
    {
        private object[] array;

        public ArrayListV2(int length)
        {
            array = new object[length];
        }

        public int Length => array.Length;

        public object this[int index]
        {
            get
            {
                if (index < 0 || index >= array.Length)
                    return null;

                return array[index];
            }

            set
            {
                if (index < 0 || index >= array.Length)
                    return;

                array[index] = value;
            }
        }
    }

    class IndexerTest
    {
        public static void TestIndexer()
        {
            ArrayListV2 list = new ArrayListV2(10);

            list[0] = "earea"; // string
            list[1] = 51; // int

            string str = (string)list[0];
            int integer = (int)list[1];

            Console.WriteLine($"List length: {list.Length}");

            list[0] = "Hello world!";
            list[3] = "HAJE forever";

            Console.WriteLine(list[0]);
            Console.WriteLine(list[3]);
            Console.WriteLine(list[13] == null);
            Console.WriteLine(list[2] == null);
        }
    }
}
