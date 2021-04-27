using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSeminar4
{
    public delegate void MessageEvent(string message);

    public class EventTestClass
    {
        public static event MessageEvent events = null;

        public static void InvokeEvent(string message)
        {
            events.Invoke(message);
            events(message);
        }
    }

    class EventTest
    {
        private static void PrintMessage(string message)
        {
            Console.WriteLine(message);
        }

        private static void PrintMessageLength(string message)
        {
            Console.WriteLine(message.Length);
        }

        private static void RevertMessage(string message)
        {
            Console.WriteLine(message.Reverse().ToArray());
        }

        public static void TestEvent()
        {
            // private 메소드도 대리자에 저장 가능
            EventTestClass.events += PrintMessage;
            EventTestClass.events += PrintMessageLength;
            EventTestClass.events += RevertMessage;

            EventTestClass.InvokeEvent("Hello world!");

            EventTestClass.events -= PrintMessage;

            EventTestClass.InvokeEvent("Hello world!");
        }
    }
}
