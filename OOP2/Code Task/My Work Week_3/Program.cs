using System;

namespace My_Work_Week_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student();
            s.name = "";
            Student.courseName = "";

            s.Cgpa = 3.5F;
            Console.WriteLine("Cgpa:" + s.Cgpa);
            Console.ReadKey();
        }
    }
}
