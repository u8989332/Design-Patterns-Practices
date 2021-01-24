using System;

namespace ResumeWithDeepCopy
{
    class Program
    {
        static void Main(string[] args)
        {
            Resume p1 = new Resume("John");
            p1.SetPersonalInfo("Male", "30");
            p1.SetWorkExperience("2005-2009", "xx corp");

            Resume p2 = (Resume)p1.Clone();
            p2.SetWorkExperience("1999-2010", "yy corp");

            Resume p3 = (Resume)p1.Clone();
            p3.SetPersonalInfo("Female", "39");

            p1.Display();
            p2.Display();
            p3.Display();

            Console.Read();
        }
    }
}
