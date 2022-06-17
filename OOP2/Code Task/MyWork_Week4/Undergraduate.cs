using System;

namespace MyWork_Week4
{
    class Undergraduate : Student
    {
        public int completecredit;

        internal int incompleteCredit;
        public Undergraduate() : base()
        {

        }
        public Undergraduate(string name, string id, string department, int completecredit, int uncompleteCredit) : base(name, id, department)
        {
            this.completecredit = completecredit;
            this.incompleteCredit = uncompleteCredit;
        }
        public void show()
        {
            Console.WriteLine("Undergraduate student details:-");
            Console.WriteLine("\nName: " + name);
            Console.WriteLine("Id: " + Id);
            Console.WriteLine("Department: " + department);
            Console.WriteLine("Complete Credit: " + completecredit);
            Console.WriteLine("Incomplete Credit: " + incompleteCredit);
            Console.ReadKey();


        }
    }
}
