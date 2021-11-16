using System;

namespace A1
{
    class Program
    {
         public int length;
        public int breath;
        public int height;
        static void Main(string[] args)
        {
            Program m1 = new Program();
            m1.length = 10;
            m1.breath = 8;
            m1.height = 22;
            Box BlackBox = new Box();
            BlackBox.less= 100;
            Console.WriteLine(m1.breath);
            System.Console.WriteLine(BlackBox.less);
            BlackBox.b = Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine(BlackBox.b);
            m1.volume();
            Car m = new Car();
            Console.Write("Enter the name of the car : ");
            m.name = Convert.ToString(Console.ReadLine());
            Console.Write("Enter the car color : ");
            m.color = Convert.ToString(Console.ReadLine());
            System.Console.Write("Enter the net worth of the car : ");
            m.money = Convert.ToInt32(Console.ReadLine());
            System.Console.Write("Enter the model of the car : ");
            m.model = Convert.ToString(Console.ReadLine());
            System.Console.WriteLine(m.name+" car is "+m.color+" in color . the model of the car is "+m.model+" and its net worth price is "+m.money);
        }
        public void volume()
        {
            int vol =  length*breath*height;
            Console.WriteLine(vol);
        }
    }
}
