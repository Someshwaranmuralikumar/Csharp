using System;
namespace marks
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your marks (out of 100) : ");
            int mark = Convert.ToInt32(Console.ReadLine());
            if(mark>=0 && mark<=100)
            {
                if(mark>=90)
                    Console.WriteLine("Grade 'A' ");
                else if(mark>=80)
                    Console.WriteLine("Grade 'B' ");
                else if(mark>=70)
                    Console.WriteLine("Grade 'C' ");
                else if(mark>=60)
                    Console.WriteLine("Grade 'D' ");
                else if(mark>=40)
                    Console.WriteLine("Grade 'E' ");
                else
                    Console.WriteLine("Grade 'Fail' ");
            }
            else
            {
                Console.WriteLine("PLease try again mark to be between 0 and 100!!!!!");
            }

        }
    }
}
