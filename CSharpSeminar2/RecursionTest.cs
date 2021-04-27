using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSeminar2
{
    class RecursionTest
    {
        public static void TestFactorial()
        {
            Console.WriteLine($"Factorial in iteration: {FactorialIter(10)}");
            Console.WriteLine($"Factorial in recursion: {FactorialRec(10)}");
        }

        private static int FactorialIter(int n)
        {
            int result = 1;
            for (int i = 2; i <= n; i++)
                result *= i;

            return result;
        }

        private static int FactorialRec(int n)
        {
            // 재귀 종료 조건
            if (n <= 1)
                return 1;

            // if 문 뒤에 return이 나오면 바로 값이 반한되고 메소드를 빠져나오므로
            // 굳이 else 문을 쓸 필요가 없음
            return n * FactorialRec(n - 1);
        }

        public static void TestFibonacci()
        {
            // Stopwatch는 프로그램 실행 시간을 잴 때 사용하는 클래스
            // new 연산자로 클래스의 인스턴스를 만들 수 있음(추후 설명)
            System.Diagnostics.Stopwatch watch = new System.Diagnostics.Stopwatch();

            watch.Start(); // 측정 시작
            Console.WriteLine($"Fibonacci in iteration: {FibonacciIter(40)}");
            watch.Stop(); // 측정 종료

            // ElapsedMilliseconds는 측정 시작부터 측정 종료까지의 시간을 밀리초 단위로 반환
            Console.WriteLine($"Iteration time: {watch.ElapsedMilliseconds}");

            watch.Reset(); // 시간 초기화

            watch.Start();
            Console.WriteLine($"Fibonacci in recursion: {FibonacciRec(40)}");
            watch.Stop();

            Console.WriteLine($"Recursion time: {watch.ElapsedMilliseconds}");
        }

        private static int FibonacciIter(int n)
        {
            if (n <= 2)
                return 1;

            int[] tmp = new int[n];
            tmp[0] = 1; tmp[1] = 1; // F(1) = F(2) = 1
            for (int i = 2; i < n; i++)
                tmp[i] = tmp[i - 1] + tmp[i - 2]; // F(n) = F(n-1) + F(n-2)

            return tmp[n - 1]; // F(n)
        }

        private static int FibonacciRec(int n)
        {
            if (n <= 2)
                return 1;

            return FibonacciRec(n - 1) + FibonacciRec(n - 2);
        }
    }
}
