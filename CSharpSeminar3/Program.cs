using System;

namespace CSharpSeminar3
{
    class Program
    {
        static void Main(string[] args)
        {
            // MethodOverloadingTest.TestOverloading();
            /*
            Animal duck = new Animal("Duck", 2, 2);

            Console.WriteLine($"{duck.Name} has {duck.LegNumber} legs and {duck.EyeNumber} eyes.");
            duck.Walk();
            duck.MakeSound();

            Animal lion = new Animal("Lion", 4, 2);
            Console.WriteLine($"{lion.Name} has {lion.LegNumber} legs and {lion.EyeNumber} eyes.");
            Console.WriteLine($"Current animal count: {Animal.AnimalCount}");

            duck.LookAt(lion);
            duck.Die();

            Console.WriteLine($"Duck is {(duck.Alive ? "alive" : "dead")}.");
            Console.WriteLine($"Current animal count: {Animal.AnimalCount}");
            */

            /*
            Animal duck = new Duck();
            duck.MakeSound();
            duck.Die();
            
            if (duck is Duck duck2)
            {
                duck2.MakeSound();
                duck2.Die();
            }

            if (duck is Duck)
            {
                Duck duck3 = duck as Duck;
                duck3.MakeSound();
                duck3.Die();
            }
            */

            

            EnumTest.TestEnum();
        }
    }
}
