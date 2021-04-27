using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSeminar2
{
    class TupleTest
    {
        public static void TestTuple()
        {
            // 튜플의 타입은 각 요소의 타입만 명시한 것으로 할 수 있음
            // 이 경우 각 요소에는 ItemN(N은 N번째 요소, 1부터 시작)로 접근 가능
            (double, double) sincos = SinCos(30);
            Console.WriteLine($"Degree: 30, sin: {sincos.Item1}, cos: {sincos.Item2}");

            // 튜플의 타입에 각 요소의 이름을 붙여줄 수 있음
            // 이 경우 각 요소에는 붙여준 이름으로 접근 가능
            (double sin, double cos) sincos2 = SinCos(60);
            Console.WriteLine($"Degree: 60, sin: {sincos2.sin}, cos: {sincos2.cos}");

            // var은 컴파일러가 변수의 타입을 추론해서 자동으로 치환하도록 하는 키워드
            // var 변수를 사용할 때에는 선언과 동시에 초기화를 해야 함.
            // var 변수를 튜플로 초기화할 경우 메소드의 반환형에 각 요소의 이름이 명시된 경우
            // 그 이름을 사용하도록 타입이 정해짐
            var sct = SinCosTan(45);
            Console.WriteLine($"Degree: 45, sin: {sct.sin}, cos: {sct.cos}, tan: {sct.tan}");

            // 튜플 타입의 변수명을 지어주는 대신 생략하고 각 요소의 이름을 붙이면
            // 그 이름 자체로 각 튜플의 요소에 접근할 수 있음
            // 이 때, 각 요소는 로컬 변수로 취급하여 이 후 같은 이름의 로컬 변수가 나올 수 없음
            // 또한 요소 일부에 타입 이름 대신 _를 사용하여 해당 요소를 무시할 수 있음
            (double sin, _, double tan) = SinCosTan(15);
            Console.WriteLine($"Degree: 15, sin: {sin}, tan: {tan}");
        }

        // 반환형이 튜플인 경우 요소명을 생략 가능
        private static (double, double) SinCos(double degree)
        {
            double radian = degree * Math.PI / 180;
            return (Math.Sin(radian), Math.Cos(radian));
        }

        // 튜플의 각 요소의 이름을 반환형에 명시하여 각 요소의 의미를 알기 쉽게 할 수 있음
        private static (double sin, double cos, double tan) SinCosTan(double degree)
        {
            double radian = degree * Math.PI / 180;
            return (Math.Sin(radian), Math.Cos(radian), Math.Tan(radian));
        }
    }
}
