using System;

namespace ResumeWithShallowCopy
{
    public class Resume : ICloneable
    {
        private string name;
        private string sex;
        private string age;
        private string timeArea;
        private string company;

        public Resume(string name)
        {
            this.name = name;
        }

        public void SetPersonalInfo(string sex, string age)
        {
            this.sex = sex;
            this.age = age;
        }

        public void SetWorkExperience(string timeArea, string company)
        {
            this.timeArea = timeArea;
            this.company = company;
        }

        public void Display()
        {
            Console.WriteLine($"{name} {sex} {age}");
            Console.WriteLine($"Work experience: {timeArea} {company}");
        }

        public object Clone()
        {
            return MemberwiseClone();
        }
    }
}
