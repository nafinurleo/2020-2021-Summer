using System;

namespace My_Work_Week5
{
    class Program
    {
        static void Main(string[] args)
        {
            // boxing
            object o1 = 10; // boxing
            object o2 = "Car";
            string str = o2.ToString();
            object o3 = 10.5;

            //unboxing
            int value = (int)o1;

            //store null value

            int? i = 15;
            double? d1 = 3.54;
            bool? flag = null;
            char? letter = 'a';

            //storing different type of data

            object[] obj = new object[3];
            obj[0] = 25;
            obj[1] = 'A';
            obj[2] = "Leo";
            Console.WriteLine(obj[0]);
            Console.WriteLine(obj[1]);
            Console.WriteLine(obj[2]);
            Console.ReadLine();

            //annonymous type
            var info = new { name = "Leo", age = 20, bloodGroup = "A+" };
            Console.WriteLine("Name: " + info.name + "Age: " + info.age + "Blood Group:" + info.bloodGroup);
            Console.ReadKey();
        }
    }
}
