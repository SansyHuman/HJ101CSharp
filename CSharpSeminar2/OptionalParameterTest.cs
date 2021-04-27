using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSeminar2
{
    class OptionalParameterTest
    {
        public static void TestOptionalParameter()
        { 
            // key1, key2 기본값 사용
            Console.WriteLine(GenerateID("이수보"));

            // key2 기본값 사용
            Console.WriteLine(GenerateID("이수보", 12));

            // key1 기본값 사용
            // 선택적 인수 몇개를 뛰어넘고 그 뒤의 인수에 값을 할당할 때에는
            // 파라미터이름: 값 형식으로 할당.
            // 이런 형식으로 사용할 때에는 파라미터의 순서는 상관 없음
            Console.WriteLine(GenerateID("이수보", key2: 52));

            Console.WriteLine(GenerateID("이수보", 31, 552));
            // 위와 같은 호출
            Console.WriteLine(GenerateID("이수보", key2: 552, key1: 31));
            // 선택적 인수가 아닌 파라미터도 파라미터이름: 값 형식으로 할당 가능
            Console.WriteLine(GenerateID(key2: 552, name: "이수보", key1: 31));
        }

        private static int GenerateID(string name, int key1 = 153, int key2 = 321)
        {
            // GetHashCode는 데이터에 따라 달라지는 고유한 수를 반환
            int hash = name.GetHashCode();

            return hash * key1 + key2;
        }
    }
}
