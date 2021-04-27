using System;
using System.Diagnostics;

namespace CSharpSeminar
{
    class Program
    {
        private static void Main(String[] args)
        {
            Stopwatch watch = new Stopwatch();

            while (true)
            {
                watch.Reset();
                watch.Start();

                byte ba = 5, bb = 6;
                for (int i = 0; i < 100000000; i++)
                {
                    byte bc = (byte)(ba + bb);
                }

                watch.Stop();

                Console.WriteLine(watch.ElapsedMilliseconds);

                watch.Reset();
                watch.Start();

                short sa = 5, sb = 6;
                for (int i = 0; i < 100000000; i++)
                {
                    short sc = (short)(sa + sb);
                }

                watch.Stop();

                Console.WriteLine(watch.ElapsedMilliseconds);

                watch.Reset();
                watch.Start();

                int ia = 5, ib = 6;
                for (int i = 0; i < 100000000; i++)
                {
                    int ic = ia + ib;
                }

                watch.Stop();

                Console.WriteLine(watch.ElapsedMilliseconds);

                watch.Reset();
                watch.Start();

                long la = 5, lb = 6;
                for (int i = 0; i < 100000000; i++)
                {
                    long lc = la + lb;
                }

                watch.Stop();

                Console.WriteLine(watch.ElapsedMilliseconds);
                Console.WriteLine();
            }
        }
    }
}
