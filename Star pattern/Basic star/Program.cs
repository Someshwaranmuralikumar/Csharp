using System;

namespace Basic_star
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            hi();
            hello();
        }
        static void hi()
        {
            Console.WriteLine("Star Pattern -1 \nA single line in vertical");
            int i;
            for(i=0;i<6;i++)
            {
                Console.WriteLine("*");
            }
            Console.ReadLine();
        }
        static void hello()
        {
            Console.WriteLine("Star Pattern -2 \n To build a square");
            int row,col;
            for(row=0;row<4;row++)
            {
                for(col=0;col<4;col++)
                {
                    Console.WriteLine("*");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
