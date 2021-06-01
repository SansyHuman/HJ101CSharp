using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSeminar
{
    class IterationTest
    {
        public static void TestWhile()
        {
            int a = 1;
            int sum = 0;
            
            while (a <= 100) // 괄호 안의 논리식이 참이면 뒤의 내용 실행
            {
                sum += a;
                a++;
                // while문의 끝에서 다시 괄호로 돌아가 논리식이 참이면 다시 뒤의 내용 실행
            }

            Console.WriteLine(sum);
        }

        public static void TestDoWhile()
        {
            int a = 101;
            int sum = 0;

            do // 뒤의 내용을 한번은 무조건 실행
            {
                sum += a;
                a++;
                // do 뒤의 모든 코드 실행 후 while 뒤의 조건 확인
            } while (a <= 100); // do-while에서는 while 괄호 뒤에 ;을 붙임

            Console.WriteLine(sum);
        }

        public static void TestFor()
        {
            int sum = 0;
            for (int a = 1; a <= 100; a++)
            {
                sum += a;
            }

            Console.WriteLine(sum);
        }

        public static void TestForEach()
        {
            int[] numArr = { 7, 9, 5, 1, 2, 5, 6, 8, 4, 1 };

            foreach(int num in numArr)
            {
                Console.Write(num);
            }
        }

        public static void TestBreakContinue()
        {
            // 13과 17로 동시에 나누어 떨어지는 첫번째 수를 프린트
            for (int i = 1; ; i++)
            {
                if (i % 13 == 0 && i % 17 == 0)
                {
                    Console.WriteLine(i);
                    break;
                }
            }

            // 1부터 10까지의 수 중에서 4 이상 8 이하의 수만 프린트
            for (int i = 1; i <= 10; i++)
            {
                if (i < 4 || i > 8)
                    continue;

                Console.WriteLine(i);
            }
        }

        public static void TestMultipleIteration()
        {
            // 구구단 출력
            for (int x = 2; x < 10; x++)
            {
                for (int y = 1; y < 10; y++)
                {
                    Console.WriteLine($"{x} x {y} = {x * y}");
                }
            }

            // 다중 반복문에서 break를 쓰면 자신이 속한 반복문만 빠져나오게 됨
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= 5; j++)
                {
                    Console.WriteLine($"{i}, {j}");
                    if (j == 2)
                        break;
                }
            }

            // 바깥쪽 반복문도 빠져나오고 싶다면 루프 뒤쪽에 레이블(이름:)을 만들고
            // goto 레이블이름 으로 레이블로 점프하도록 해야함
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= 5; j++)
                {
                    Console.WriteLine($"{i}, {j}");
                    if (j == 2)
                        goto OuterLoop;
                }
            }
            OuterLoop:
            return;
        }
    }
}
