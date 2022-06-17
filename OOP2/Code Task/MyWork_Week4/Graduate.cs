using System;

namespace MyWork_Week4
{
    class Graduate : Student
    {
        public double cgpa;

        public Graduate() : base()
        {
        }
        public Graduate(string name, string id, string department, double cgpa) : base(name, id, department)
        {
            this.cgpa = cgpa;
        }
        public void show()
        {
            Console.WriteLine("Graduate student details:-");
            Console.WriteLine("\nName: " + name);
            Console.WriteLine("Id: " + Id);
            Console.WriteLine("Department: " + department);
            Console.WriteLine("Cgpa: " + cgpa);
            Console.ReadKey();
        }
    }
}
