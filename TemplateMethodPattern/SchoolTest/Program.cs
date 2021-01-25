using System;

namespace SchoolTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Student A copy-writing paper: ");
            TestPaper studentA = new TestPaperA();
            studentA.TestQuestion1();
            studentA.TestQuestion2();
            studentA.TestQuestion3();

            Console.WriteLine();

            Console.WriteLine("Student B copy-writing paper: ");
            TestPaper studentB = new TestPaperB();
            studentB.TestQuestion1();
            studentB.TestQuestion2();
            studentB.TestQuestion3();
            Console.Read();
        }
    }
}
