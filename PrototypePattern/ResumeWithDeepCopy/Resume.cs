using System;

namespace ResumeWithDeepCopy
{
    public class Resume : ICloneable
    {
        private string name;
        private string sex;
        private string age;
        private WorkExperience work;

        public Resume(string name)
        {
            this.name = name;
            this.work = new WorkExperience();
        }

        private Resume(WorkExperience work)
        {
            this.work = (WorkExperience)work.Clone();
        }

        public void SetPersonalInfo(string sex, string age)
        {
            this.sex = sex;
            this.age = age;
        }

        public void SetWorkExperience(string timeArea, string company)
        {
            work.TimeArea = timeArea;
            work.Company = company;
        }

        public void Display()
        {
            Console.WriteLine($"{name} {sex} {age}");
            Console.WriteLine($"Work experience: {work.TimeArea} {work.Company}");
        }

        public object Clone()
        {
            Resume result = new Resume(this.work);
            result.name = this.name;
            result.sex = this.sex;
            result.age = this.age;
            return result;
        }
    }
}
