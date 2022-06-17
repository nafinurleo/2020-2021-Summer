using System;

namespace MyWork_Week4
{
    class Program
    {
        static void Main(string[] args)
        {

            Undergraduate ut = new Undergraduate("Leo", "20-42195-1", "CSE", 62, 86);
            ut.show();

            Graduate gt = new Graduate("Lorin", "16-54672-1", "CSE", 3.65);
            gt.show();
        }
    }
}