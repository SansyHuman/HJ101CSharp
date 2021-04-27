using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSeminar3
{
    class MethodOverloadingTest
    {
        // 메소드가 하나의 값 또는 하나의 식의 결과값만 반환하면 => 값/식 형식으로 축약 가능
        public static int Add(int a, int b) => a + b;

        public static double Add(double a, double b) => a + b;

        public static int Add(int a, int b, int c) => a + b + c;

        public static void TestOverloading()
        {
            // GetType 메소드는 모든 객체에 정의되어 있음
            // GetType 메소드는 객체의 타입을 반환
            Console.WriteLine(Add(2, 3).GetType());

            // 메소드 오버로딩 시 형변환이 필요할 때 암시적 형변환이 이뤄지는 쪽을 호출
            // double은 int로 암시적 형변환이 불가능하므로 int를 double로 변환
            Console.WriteLine(Add(2, 3.0).GetType());

            Console.WriteLine(Add(2.0, 3.0).GetType());

            // float는 int로 암시적 형변환이 불가능하므로 float를 double로 변환
            Console.WriteLine(Add(2.0f, 3.0f).GetType());

            // 메소드의 파라미터 개수에 따라 호출되는 메소드 선택
            Console.WriteLine(Add(2, 3, 4).GetType());
        }
    }
}
