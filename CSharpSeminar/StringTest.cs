using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSeminar
{
    class StringTest
    {
        public static void TestString()
        {
            string text = "Hello world!";

            // 모든 객체에는 ToString 메소드가 있어 객체를 적당한 문자열로 바꿔줌
            string numToStr = 45.ToString();
            float tmp = 4.7f;
            string floatToStr = tmp.ToString();

            Console.WriteLine(text);
            Console.WriteLine(numToStr);
            Console.WriteLine(floatToStr);

            string name = "이수보";
            int age = 21;

            // 문자열 앞에 $를 붙이면 문자열에 다른 문자열이나 숫자를 삽입할 수 있음
            // 삽입할 리터럴이나 변수를 문자열 중간의 중괄호에 삽입
            Console.WriteLine($"My name is {name} and I'm {age} years old.");

            // 위와 똑같은 표현이지만 위쪽이 훨씬 짧고 간단함
            // 괄호 안에 리터럴이나 변수를 삽입할 인덱스를 적고 그 뒤에 순서대로 파라미터로 WriteLine에 넘겨줌
            Console.WriteLine("My name is {0} and I'm {1} years old.", name, age);

            // string의 Format 메소드로 바로 출력하는 대신 문자열로 만들 수 있음
            string format = string.Format("My name is {0} and I'm {1} years old.", name, age);
            Console.WriteLine(format);
        }

        public static void TestStringMethods()
        {
            string text1 = "Hello world!";
            string text2 = "there.";

            // Substring 메소드는 문자열의 일부를 잘라 새로운 문자열로 만듦
            // 첫번째 파라미터는 시작 인덱스(0부터 시작), 두번째 파라미터는 시작인덱스부터 자를 문자열의 길이
            string subtxt1 = text1.Substring(0, 5);
            Console.WriteLine(subtxt1);

            string subtxt2 = text1.Substring(0, 6);
            // Trim 메소드는 문자열의 시작과 끝의 공백을 지운 새 문자열을 만듦
            Console.WriteLine(subtxt2.Trim());

            // Remove 메소드는 Substring과 정확히 반대의 일을 함
            Console.WriteLine(text1.Remove(1, 3));

            // Insert 메소드는 기존 문자열의 중간에 문자열을 집어넣음
            // 첫번째 파라미터는 집어넣을 문자열의 시작 위치, 두번째 파라미터는 집어넣을 문자열
            Console.WriteLine(text1.Insert(6, "god damn "));

            // 문자열을 이을 때는 + 연산자 사용
            Console.WriteLine(subtxt2 + text2);
        }
    }
}
