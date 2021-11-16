using System;

namespace RigtAngle
{
    class A
    {
        public static void xyz()
        {
           Console.WriteLine(" ");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int i,j;
            for(i=1;i<=5;i++)
            {
                for(j=1;j<5;j++)
                {
                    Console.Write(" ");
                }
                for(j=1;j<=i;j++)
                {
                    if(i==5||j==1||j==i)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
