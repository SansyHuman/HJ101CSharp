using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSeminar3
{
    /*
    class Animal
    {
        private int legNum;
        private int eyeNum;
        private bool alive;

        private static int animalCount;

        static Animal()
        {
            animalCount = 0;
        }

        private static void AddAnimal()
        {
            animalCount++;
        }

        private static void DecreaseAnimal()
        {
            animalCount--;
        }

        public static int AnimalCount => animalCount;

        public Animal(string name, int legNum, int eyeNum)
        {
            Name = name;

            if (legNum < 0)
                legNum = 0;
            this.legNum = legNum;

            if (eyeNum < 0)
                eyeNum = 0;
            this.eyeNum = eyeNum;

            alive = true;

            AddAnimal();
        }

        public string Name { get; private set; }

        public int LegNumber
        {
            get => legNum;

            private set
            {
                if (value < 0)
                    value = 0;
                legNum = value;
            }
        }

        public int EyeNumber => eyeNum;

        public bool Alive => alive;

        public void Walk()
        {
            if (legNum == 0)
                Console.WriteLine($"{Name} cannot walk!");
            else
                Console.WriteLine($"{Name} is walking.");
        }

        public void MakeSound()
        {
            Console.WriteLine($"{Name} makes generic sound.");
        }

        public void LookAt(Animal target)
        {
            if (eyeNum == 0)
                Console.WriteLine($"{Name} cannot see!");
            else
                Console.WriteLine($"{Name} is looking at {target.Name}.");
        }

        public void Die()
        {
            alive = false;
            Console.WriteLine($"{Name} is dead!");
            DecreaseAnimal();
        }
    }
    */

    /*
    class Animal
    {
        private const string Domain = "Eukaria";

        private readonly string name;
        private int legNum;
        private int eyeNum;
        private bool alive;

        private static int animalCount;

        static Animal()
        {
            animalCount = 0;
        }

        private static void AddAnimal()
        {
            animalCount++;
        }

        private static void DecreaseAnimal()
        {
            animalCount--;
        }

        public static int AnimalCount => animalCount;

        public Animal(string name, int legNum, int eyeNum)
        {
            this.name = name;

            if (legNum < 0)
                legNum = 0;
            this.legNum = legNum;

            if (eyeNum < 0)
                eyeNum = 0;
            this.eyeNum = eyeNum;

            alive = true;

            AddAnimal();
        }

        public string Name => name;

        public int LegNumber
        {
            get => legNum;

            private set
            {
                if (value < 0)
                    value = 0;
                legNum = value;
            }
        }

        public int EyeNumber => eyeNum;

        public bool Alive => alive;

        public void Walk()
        {
            if (legNum == 0)
                Console.WriteLine($"{Name} cannot walk!");
            else
                Console.WriteLine($"{Name} is walking.");
        }

        public void MakeSound()
        {
            Console.WriteLine($"{Name} makes generic sound.");
        }

        public void LookAt(Animal target)
        {
            if (eyeNum == 0)
                Console.WriteLine($"{Name} cannot see!");
            else
                Console.WriteLine($"{Name} is looking at {target.Name}.");
        }

        public void Die()
        {
            alive = false;
            Console.WriteLine($"{Name} is dead!");
            DecreaseAnimal();
        }
    }
    */

    struct Student
    {
        public string name;
        public int number;
        public string birthday;
    }
    
    abstract class Animal
    {
        private const string Domain = "Eukaria";

        private readonly string name;
        private int legNum;
        private int eyeNum;
        private bool alive;

        private static int animalCount;

        static Animal()
        {
            animalCount = 0;
        }

        private static void AddAnimal()
        {
            animalCount++;
        }

        private static void DecreaseAnimal()
        {
            animalCount--;
        }

        public static int AnimalCount => animalCount;

        public Animal(string name, int legNum, int eyeNum)
        {
            this.name = name;

            if (legNum < 0)
                legNum = 0;
            this.legNum = legNum;

            if (eyeNum < 0)
                eyeNum = 0;
            this.eyeNum = eyeNum;

            alive = true;

            AddAnimal();
        }

        public string Name => name;

        public int LegNumber
        {
            get => legNum;

            private set
            {
                if (value < 0)
                    value = 0;
                legNum = value;
            }
        }

        public int EyeNumber => eyeNum;

        public bool Alive => alive;

        public void Walk()
        {
            if (legNum == 0)
                Console.WriteLine($"{Name} cannot walk!");
            else
                Console.WriteLine($"{Name} is walking.");
        }

        public abstract void MakeSound();

        public void LookAt(Animal target)
        {
            if (eyeNum == 0)
                Console.WriteLine($"{Name} cannot see!");
            else
                Console.WriteLine($"{Name} is looking at {target.Name}.");
        }

        public virtual void Die()
        {
            alive = false;
            Console.WriteLine($"{Name} is dead!");
            DecreaseAnimal();
        }
    }
    
}
