using System;

namespace HW2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Func1 result: {Func1(9, 15)}");

            // out 파라미터에 out 타입 이름 형식으로 변수 선언과 동시에
            // 참조를 넘겨줄 수 있음
            Func2(9, 15, out int x, out int y);
            Console.WriteLine($"Func2 result: {(x, y)}");
        }

        public static (int, int) Func1(int x, int y)
        {

        }

        public static void Func2(int x, int y, out int resX, out int resY)
        {

        }
    }
}
