using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSeminar3
{
    class AAA
    {
        public int a;
        public int b;
    }

    struct BBB
    {
        public int a;
        public int b;
    }

    class StructTest
    {
        public static void TestStruct()
        {
            // public 인스턴스 멤버는 new 연산자 뒤에 중괄호에서 아래와 같이 초기화할 수 있음
            AAA a1 = new AAA() { a = 5, b = 4 };
            BBB b1 = new BBB() { a = 5, b = 4 };

            AAA a2 = a1;
            BBB b2 = b1;

            a2.a = 3; a2.b = 1;
            b2.a = 3; b2.b = 1;

            Console.WriteLine($"A1: {a1.a}, {a1.b}");
            Console.WriteLine($"A2: {a2.a}, {a2.b}");
            Console.WriteLine($"B1: {b1.a}, {b1.b}");
            Console.WriteLine($"B2: {b2.a}, {b2.b}");
        }
    }
}
