using System;

namespace SchoolTest
{
    public class TestPaper
    {
        public void TestQuestion1()
        {
            Console.WriteLine("If a married man refrains from having affairs with other women we can say that he is");
            Console.WriteLine("A. Loyal B. Endearing C. Faithful D. Reassuring");
            Console.WriteLine("Answer: " + Answer1());
        }
        public void TestQuestion2()
        {
            Console.WriteLine("What is the most suitable word to describe someone who is a deep and systematic thinker");
            Console.WriteLine("A. clever B. Smart C. Intelligent D. Dull");
            Console.WriteLine("Answer: " + Answer2());
        }
        public void TestQuestion3()
        {
            Console.WriteLine("Animals which like to play can be said to be");
            Console.WriteLine("A. Play-liking  B. Play-centered  C. Playful  D. Players");
            Console.WriteLine("Answer: " + Answer3());
        }

        protected virtual string Answer1()
        {
            return string.Empty;
        }

        protected virtual string Answer2()
        {
            return string.Empty;
        }

        protected virtual string Answer3()
        {
            return string.Empty;
        }
    }
}
