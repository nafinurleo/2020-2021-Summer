using System;

namespace My_Work_Week7
{
    class Program
    {
        static void Main(string[] args)
        {
            Archeologist a = new Archeologist("Mortimer Wheeler", "56-56987-2", 542);
            a.archeologistinfo();
            a.Rank(1);
            a.SalaryCalculate(150000, 75000);
            a[0] = "Locate suitable excavation sites";
            a[1] = "Preserve artefacts";
            a[2] = "Produce simulations";
            a[3] = "Supervise staff";
            Console.WriteLine("\nWork Name: " + a[0]);
            Console.WriteLine("Work Name: " + a[1]);
            Console.WriteLine("Work Name: " + a[2]);
            Console.WriteLine("Work Name: " + a[3]);
            Console.ReadKey();
        }
    }
}
