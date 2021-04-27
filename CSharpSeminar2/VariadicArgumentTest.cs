using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSeminar2
{
    class VariadicArgumentTest
    {
        public static void TestVariadicArgument()
        {
            Println("Hello world!");
            Println("My name is {0}.", "이수보");
            Println("I'm {0} years old and live in {1}.", 21, "구미");
            // 가변 인자에 바로 배열을 넘겨도 됨
            Println("{0}, {1}, {2}", new object[] { 51, "KAIST", 3.14 });
        }

        private static void Println(string format, params object[] args)
        {
            // string은 수정이 불가능하므로 참조만 복사해도 됨
            string result = format;
            for (int i = 0; i < args.Length; i++)
            {
                // Replace 메소드는 문자열에서 특정 문자열을 찾아 해당하는 부분을 모두 다른 문자열로 치환
                // string을 수정하는 메소드는 새로운 string을 반환하므로 로컬 변수에 다시 대입
                result = result.Replace("{" + i + "}", args[i].ToString());
            }

            Console.WriteLine(result);
        }
    }
}
