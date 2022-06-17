using System;

namespace MyWork_Week2
{
    class SemesterDetails
    {
        int semesterNumber;
        float GPA;

        public SemesterDetails()
        {
            semesterNumber = 0;
            GPA = 0;
        }
        public SemesterDetails(int semesterNumber)
        {
            this.semesterNumber = semesterNumber;
        }
        public void GPACalculator(int creditsTaken, params float[] creditsEarned)
        {
            float totalCreditsEarned = 0;
            for (int i = 0; i < creditsEarned.Length; i++)
                totalCreditsEarned += creditsEarned[i];
            GPA = totalCreditsEarned / creditsTaken;
        }
        public void ListOfSubjects(params string[] listOfSub)
        {
            foreach (string i in listOfSub)
                Console.WriteLine(i);
        }
        public void ShowInfo()
        {
            Console.WriteLine("Semester number: " + semesterNumber);
            Console.WriteLine("GPA: " + GPA);
            Console.ReadKey();
        }
    }
}
