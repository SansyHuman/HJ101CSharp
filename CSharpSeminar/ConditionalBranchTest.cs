using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSeminar
{
    class ConditionalBranchTest
    {
        public static void TestConditionalBranch()
        {
            int a = 30;
            // if 뒤의 논리식의 값이 true라면 뒤의 내용을 실행
            // if 뒤의 코드가 하나라면 중괄호 생략 가능
            if (a < 5)
                Console.WriteLine("a is less than 5.");
            // else 뒤의 코드는 바로 앞의 if 뒤의 논리식의 값이 false일 때 실행
            // else 뒤에 바로 if가 온다면 else if로 한줄로 줄여 쓸 수 있음
            else if (a < 20)
            {
                Console.WriteLine("a is larger than or equal to 5");
                Console.WriteLine("and less than 20.");
            }
            else
                Console.WriteLine("a is larger than or equal to 20");
        }

        public static void TestTernaryOperator()
        {
            int a = 14;
            string eval = a % 7 == 0 ? "a is multiple of 7." : "a is not multiple of 7.";
            Console.WriteLine(eval);
        }

        public static void TestSwitch()
        {
            int n = 5;

            switch (n)
            {
                case 1:
                    Console.WriteLine("One!");
                    break;
                // 한 섹션에 여러 case가 있을 수 있음
                case 2:
                case 3:
                    Console.WriteLine("Two or Three");
                    break;
                case 4:
                    Console.WriteLine("Death");
                    break;
                default:
                    Console.WriteLine("Whatever");
                    break;
            }
        }
    }
}
