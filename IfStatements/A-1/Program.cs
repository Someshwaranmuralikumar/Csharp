using System;

namespace A_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int Salary;
            double total,hrd,da;
            Console.WriteLine("Enter the basic salary : ");
            Salary = Convert.ToInt32(Console.ReadLine());
            if(Salary<=10000)
            {
                da = Salary*0.8;
                hrd = Salary*0.2;
            }
            else if(Salary<=20000)
            {
                da = Salary*0.9;
                hrd = Salary*0.25;
            }
            else
            {
                da = Salary*0.95;
                hrd = Salary*0.3;
            }
            total = Salary+da+hrd;
            Console.WriteLine("Your gross salary is "+total);            

        }
    }
}
