using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSeminar3
{
    class Car : IMovable, IRotatable
    {
        private int x;
        private int y;
        private float angle;

        public int X => x;

        public int Y => y;

        public float Angle => angle;

        public Car(int initX, int initY, int initAngle)
        {
            x = initX;
            y = initY;
            angle = initAngle;
        }

        public virtual void Move(int dx, int dy)
        {
            x += dx;
            y += dy;
        }

        public void Rotate(float dtheta)
        {
            angle += dtheta;
        }
    }

    class CCar : Car 
    {
        public CCar() : base(0, 0, 0) { }

        public override void Move(int dx, int dy)
        {
            base.Move(dx, dy);
            Console.WriteLine($"CCar moved to ({X}, {Y})");
        }
    }

    class MoveRotateTest
    {
        public static void TestMoveRotate()
        {
            Car car1 = new Car(1, 3, 50);
            car1.Rotate(45);
            car1.Move(3, -5);
            // \n을 문자열에 넣으면 넣은 부분에서 문자열의 줄이 바뀌어 출력됨
            Console.WriteLine($"Car 1 pos: ({car1.X}, {car1.Y})\nCar 2 rotation: {car1.Angle} degrees");

            CCar car2 = new CCar();
            car2.Rotate(45);
            car2.Move(3, -5);
            Console.WriteLine($"Car 2 pos: ({car2.X}, {car2.Y})\nCar 2 rotation: {car2.Angle} degrees");
        }
    }
}
