using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSeminar4
{
    public class ArrayListV4<T>
    {
        private T[] array;

        public ArrayListV4(int length)
        {
            array = new T[length];
        }

        public int Length => array.Length;

        public T this[int index]
        {
            get
            {
                if (index < 0 || index >= array.Length)
                    throw new IndexOutOfRangeException();

                return array[index];
            }

            set
            {
                if (index < 0 || index >= array.Length)
                    throw new IndexOutOfRangeException();

                array[index] = value;
            }
        }
    }

    class ExceptionTest
    {
        public static void TestException()
        {
            ArrayListV4<string> list = new ArrayListV4<string>(10);

            Console.WriteLine($"List length: {list.Length}");

            // list[15] = "Hello world!"; // error
            string str = list[-3]; // error
        }
    }
}
