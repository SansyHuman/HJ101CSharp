using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSeminar3
{
    
    class Duck : Animal
    {
        public Duck() : base("Duck", 2, 2)
        {

        }

        public override void Die()
        {
            base.Die(); // 부모 클래스의 메소드 호출(필요없으면 생략해도 됨)
            Console.WriteLine("It dropped a feather.");
        }

        public override void MakeSound()
        {
            Console.WriteLine("Quack!");
        }
    }

    class Lion : Animal
    {
        public Lion() : base("Lion", 4, 2) { }

        public override void MakeSound()
        {
            throw new NotImplementedException();
        }
    }
    
}
