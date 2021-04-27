using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSeminar
{
    class OperatorTest
    {
        public static void TestArithmeticOperators()
        {
            int a = 15, b = 4;
            Console.WriteLine(a + b);
            Console.WriteLine(a - b);
            Console.WriteLine(a * b);

            // 정수형 끼리의 나눗셈은 몫이 정수로 나옴
            Console.WriteLine(a / b);

            // 정수형 끼리의 나눗셈의 몫이 실수로 나오게 하려면 둘 중 하나 이상을 실수형으로 변환
            Console.WriteLine(a / (double)b);
            Console.WriteLine(a % b);

            double c = 0.5, d = 1.7;
            Console.WriteLine(c + d);
            Console.WriteLine(c - d);
            Console.WriteLine(c * d);
            Console.WriteLine(c / d);
        }

        public static void TestArithmeticOperators2()
        {
            int a = 6;
            a += 5; // a = a + 5
            Console.WriteLine(a);

            a -= 4; // a = a - 4
            Console.WriteLine(a);

            a *= 7; // a = a * 7
            Console.WriteLine(a);

            a /= 7; // a = a / 7
            Console.WriteLine(a);

            a %= 3; // a = a % 3
            Console.WriteLine(a);

            a++; // a = a + 1
            Console.WriteLine(a);

            a--; // a = a - 1
            Console.WriteLine(a);
        }

        public static void TestLogicalOperators()
        {
            int a = 10, b = 13;
            bool c = a == b; // equal
            Console.WriteLine(c);

            Console.WriteLine(a != b); // not equal
            Console.WriteLine(a < b);
            Console.WriteLine(a > b);
            Console.WriteLine(a <= b);
            Console.WriteLine(a >= b);

            bool d = true, e = false;
            Console.WriteLine(d && e); // and
            Console.WriteLine(d || e); // or
            Console.WriteLine(!d); // not
        }
    }
}
