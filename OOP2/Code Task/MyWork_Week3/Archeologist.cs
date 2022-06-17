using System;

namespace MyWork_Week3
{
    class Archeologist
    {
        const int minsalary = 40000;
        readonly int maxsalary;

        public Archeologist()
        {

        }
        public Archeologist(string name, string id, int maxsalary)
        {
            this.name = name;
            this.id = id;

            this.maxsalary = maxsalary;
        }
        public string name;
        internal string id;
        private string phone;
        public static string organizationName;
        public void Test(params object[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("Archeologist Information:" + arr[i]);
            }
        }
        public string Phone
        {
            set;
            get;
        }
        public void show()
        {
            Console.WriteLine("Archeologist Name:" + name);
            Console.WriteLine("ID:" + id);
            Console.WriteLine("Organization:" + organizationName);
            Console.WriteLine("MaxSalary:" + maxsalary);
            Console.ReadKey();
        }
    }
}
