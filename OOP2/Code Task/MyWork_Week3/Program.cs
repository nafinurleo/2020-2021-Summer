using System;

namespace MyWork_Week3
{
    class Program
    {
        struct Archeologist
        {
            public string name;
            public int salary;
            public Archeologist(string name, int salary)
            {
                this.name = name;
                this.salary = salary;
            }
            public void show()
            {
                Console.WriteLine("Name:" + name);
                Console.WriteLine("Salary:" + salary);
            }
            public void operation()
            {
                Console.WriteLine(name.ToLower());
                Console.WriteLine(name.ToUpper());
            }
        }

            static void Main(string[] args)
        {

           Archeologist a = new Archeologist("Leo", 50000);
            a.show();
            a.operation();
            Console.ReadKey();
        }
    }
}
