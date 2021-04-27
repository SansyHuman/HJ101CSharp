using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSeminar4
{
    public class ArrayListV3<T>
    {
        private T[] array;

        public ArrayListV3(int length)
        {
            array = new T[length];
        }

        public int Length => array.Length;

        public T this[int index]
        {
            get
            {
                // default 연산자는 괄호 안의 타입의 기본값을 반환
                // 형식 매개변수는 참조형이 아닐 수 있으므로 null 반환 불가
                if (index < 0 || index >= array.Length)
                    return default(T);

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

    class GenericTest
    {
        public static void TestGeneric()
        {
            ArrayListV3<string> list = new ArrayListV3<string>(10);

            // list[1] = 51; // error

            Console.WriteLine($"List length: {list.Length}");

            list[0] = "Hello world!";
            list[3] = "HAJE forever";

            string helloWorld = list[0];

            Console.WriteLine(helloWorld);
            Console.WriteLine(list[3]);
            Console.WriteLine(list[13] == null);
            Console.WriteLine(list[2] == null);
        }
    }
}
