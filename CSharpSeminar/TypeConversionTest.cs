using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSeminar
{
    class TypeConversionTest
    {
        public static void TestConversions()
        {
            int a = 1234;
            long b = a; // 암시적 형변환
            long c = 2147483649;
            int d = (int)c; // 명시적 형변환

            float e = 1.1234f;
            double f = e;
            double g = 0.12345678987;
            float h = (float)g;

            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine(d);
            Console.WriteLine(e);
            Console.WriteLine(f);
            Console.WriteLine(g);
            Console.WriteLine(h);
        }
    }
}
