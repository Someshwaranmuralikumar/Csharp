using System;

namespace jagged
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            jagged();
            newMethod();
        }
        static void jagged()
        {
            int[][] jagged = new int[5][];
                new int[] {1,2,3,4};
                new int[] {43,5,23,2};
                new int[] {0,423,23,12,12};
                new int[] {1,232,43,435,54};
                new int[]{};
            System.Console.WriteLine("The length of the jagged is : {0}",jagged.Length);
            System.Console.WriteLine("The length off the single string : {0}",jagged[0].Length);
            for(int i=0;i<jagged.Length;i++)
            {
                Console.WriteLine("Row{[0]}: ",i);
                for(int j=0;i<jagged[i].Length;j++)
                {
                    Console.Write("{0}",jagged[i][j]);
                }
                Console.WriteLine(" ");
            }
        }
        static void newMethod()
        {
            int a= 0;
            for(int i =0;i<10;i++)
            {
                Console.Write("a : {0}\n",a);
                a = a+5;
            }
            Console.Write(" ");   
        }
        static void Method1()
        {
            
        }
    }
}
