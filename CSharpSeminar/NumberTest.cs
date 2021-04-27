using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSeminar
{
    class NumberTest
    {
        public static void TestNumbers()
        {
            // 모든 실수는 기본적으로 double형
            // float형 변수에 값을 대입하려면 f 접미사를 붙임
            float piF = 3.141592653589793238462643383279502884197169399375105820974944f;
            double piD = 3.141592653589793238462643383279502884197169399375105820974944;
            // decimal형 변수에 값을 대입하려면 m 접미사를 붙임
            decimal piDC = 3.141592653589793238462643383279502884197169399375105820974944m;

            Console.WriteLine(piF);
            Console.WriteLine(piD);
            Console.WriteLine(piDC);

            // 모든 정수는 기본적으로 int형
            int a = 8455664;
            uint b = 2147483649; // 2147483649U
            long c = 1000000000000000000; // 1000000000000000000L
            ulong d = 9999999999999999999; // 9999999999999999999UL

            // char 형식은 유니코드 숫자를 대입해도 되지만 보통 작은따옴표 안에 문자 하나를 넣어 사용
            char e = 'f';

            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine(d);
            Console.WriteLine(e);
        }
    }
}
