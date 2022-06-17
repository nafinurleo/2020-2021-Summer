using System;

namespace MyWork_Week2
{
    class Program
    {
        static void Main(string[] args)
        {
            SemesterDetails s1 = new SemesterDetails(6);
            s1.GPACalculator(19, 12, 11.25F, 12, 11.25F, 12F, 12, 4);
            s1.ListOfSubjects("OOP2", "DLC", "CG", "Math-3", "BS", "Math-1", "IEC_Lab");
            s1.ShowInfo();
            Console.ReadKey();
        }
    }
    }
