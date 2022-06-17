using System;

namespace MyWork_Week4
{
    class Student
    {
        public string name;
        private string id;
        internal string department;

        public Student()
        {
        }
        public Student(string name, string id, string department)
        {
            this.name = name;
            this.id = id;
            this.department = department;
        }
        public string Id
        {
            get { return id; }
        }
    }
}
