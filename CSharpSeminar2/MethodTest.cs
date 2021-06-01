using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSeminar2
{
    class MethodTest
    {
        public static void TestMethods()
        {
            // 다른 클래스의 메소드를 호출할 때에는
            // (네임스페이스가 다른 경우 네임스페이스.)클래스이름.메소드이름(파라미터)로 호출
            Console.WriteLine(NumberTester.IsPositiveNumber(5));
            Console.WriteLine(NumberTester.IsPositiveNumber(-3));

            Console.WriteLine(AddTwoNumbers(6, 9));
            Console.WriteLine(AddTwoNumbers(2, 3));
        }

        private static int AddTwoNumbers(int num1, int num2)
        {
            return num1 + num2;
        }
    }

    class NumberTester
    {
        public static bool IsPositiveNumber(int num)
        {
            return num > 0;

            // bool result = num > 0;
            // return result;
        }
    }
}
