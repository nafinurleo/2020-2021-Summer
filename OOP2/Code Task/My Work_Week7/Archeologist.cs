using System;

namespace My_Work_Week7
{
    class Archeologist : ICadw, IQs
    {
        public string name;
        public string id;
        public int siteNo;

        public Archeologist()
        {
        }

        public Archeologist(string name, string id, int siteNo)
        {
            this.name = name;
            this.id = id;
            this.siteNo = siteNo;
        }

        private string[] work = new string[4];

        public string this[int w]
        {
            set
            {
                work[w] = value;
            }

            get
            {
                return work[w];
            }
        }

        public void archeologistinfo()
        {
            Console.WriteLine("Archeologist Name: " + name);
            Console.WriteLine("Archeologist Id: " + id);
            Console.WriteLine("Archeologist Site: " + siteNo);

        }

        public void SalaryCalculate(int basic, int bonus)
        {
            int salary = basic * 12 + bonus * 3;
            Console.WriteLine("Salary: " + salary);
        }

        public void Rank(int rank)
        {
            Console.WriteLine("Rank: " + rank);
        }
    }
}
