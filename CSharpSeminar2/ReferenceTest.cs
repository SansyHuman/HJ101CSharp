using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSeminar2
{
    class ReferenceTest
    {
        public static void TestReference()
        {
            int num = 5;
            AddOne(ref num);
            Console.WriteLine($"num: {num}");

            double sin, cos, degree = 45;
            SinCos(in degree, out sin, out cos);
            Console.WriteLine($"Angle: {degree}, sin: {sin}, cos: {cos}");

            degree = 30;
            SinCos(degree, out sin, out cos);
            Console.WriteLine($"Angle: {degree}, sin: {sin}, cos: {cos}");

            SinCos(60, out sin, out cos);
            Console.WriteLine($"Angle: {60}, sin: {sin}, cos: {cos}");
        }

        private static void AddOne(ref int num)
        {
            num += 1;
        }

        private static void SinCos(in double degree, out double sin, out double cos)
        {
            double radian = degree * Math.PI / 180;
            sin = Math.Sin(radian); cos = Math.Cos(radian);
        }
    }
}
