using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSeminar
{
    class ArrayTest
    {
        public static void TestArray()
        {
            int[] a = new int[6]; // 배열의 길이를 명시하여 모든 값을 기본값으로 초기화
            int[] b = new int[4] { 1, 5, 6, 9 }; // 배열 길이 선언과 동시에 임의값으로 초기화
            int[] c = { 6, 8, 9, 10, 15 }; // 임의값으로 초기화할 경우 배열 길이 선언을 생략 가능

            Console.WriteLine(a.Length); // 배열은 자신의 길이를 변수 Length에 저장하고 있음
            Console.WriteLine(b[0]); // 배열의 첫번째 값은 0번째로 계산. [n]로 배열의 n번째 값에 접근
            Console.WriteLine(c[6]); // 배열의 범위를 넘어가는 인덱스를 사용시 에러 발생
        }

        public static void TestMultiDimensionArray()
        {
            int[,] a = new int[3, 4]; // 배열의 각 차원의 길이는 콤마로 구분
            int[,] b = { { 1, 3, 4, 5 }, { 4, 9, 6, 3 } }; // 각 행의 길이는 같아야 함

            Console.WriteLine(a.GetLength(0)); // 0차원의 길이(행의 개수)
            Console.WriteLine(a.GetLength(1)); // 1차원의 길이(열의 개수)
            Console.WriteLine(b[1, 2]); // 각 차원의 인덱스를 콤마로 구분

            int[][] jagged = new int[3][]; // 각 행의 길이를 다르게 정할 수 있는 배열

            // int[][] 배열은 int[]형의 배열로 취급
            // jagged 배열의 0차원의 각 요소의 타입은 int[] 배열
            jagged[0] = new int[5] { 1, 2, 3, 4, 5 };
            jagged[1] = new int[3] { 5, 2, 1 };
            jagged[2] = new int[1] { 0 };

            Console.WriteLine(jagged.Length); // int[] 배열의 길이(0차원의 길이)
            Console.WriteLine(jagged[1].Length); // 0차원의 각 요소의 길이는 따로 접근해야 함
            Console.WriteLine(jagged[1][0]); // 일반적인 다차원 배열과 다르게 각 차원의 인덱스를 대괄호로 구분
        }
    }
}
