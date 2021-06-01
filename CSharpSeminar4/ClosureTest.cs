using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSeminar4
{
    class ClosureTest
    {
        public static void TestClosure()
        {
            int a = 5;
            int b = 6;

            // 코드가 리턴값만 있는 경우 중괄호와 return 생략 가능
            Func<int> c = () => a + b;
            Action d = () =>
            {
                a = 3;
                b = 5;
            };

            Console.WriteLine($"a: {a}, b: {b}, a + b: {c()}");
            d();
            Console.WriteLine($"a: {a}, b: {b}, a + b: {c()}");
        }

        public static void TestClosureList()
        {
            List<Func<int, int>> funList = new List<Func<int, int>>();

            for (int i = 0; i < 10; i++)
            {
                funList.Add(num => num + i);
            }

            for (int i = 0; i < funList.Count; i++)
            {
                Console.WriteLine(funList[i](10));
            }
        }
    }
}
