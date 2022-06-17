using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_Work_Week_3
{
    class Student
    {
        //public, private, internal, protected, protected internal

        public string name;
        private float cgpa;
        private string phone;
        internal string id;

        //class variable
        public static string courseName;
        //instance variable, local variable
        public void test(int x, int y)
        {
            int z = x + y;
            for(int i = 0; i<5; i++)
            {
                if (z > 50)
                {
                    int a = z;
                }
            }
        }
        public void SetCgpa(float cgpa)
        {
            this.cgpa = cgpa;

        }
        public float GetCgpa()
        {
            return cgpa;
        }

        public float Cgpa
        {
            set
            {
                cgpa = value;
            }
            get
            {
                return cgpa;
            }
        }

    }
}
