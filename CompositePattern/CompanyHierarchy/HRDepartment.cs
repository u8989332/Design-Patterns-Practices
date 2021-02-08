using System;

namespace CompanyHierarchy
{
    class HRDepartment : Company
    {
        public HRDepartment(string name) : base(name)
        {

        }

        public override void Add(Company c)
        {
            
        }
        public override void Remove(Company c)
        {

        }
        public override void Display(int depth)
        {
            Console.WriteLine(new string('-', depth) + name);
        }

        public override void LineOfDuty()
        {
            Console.WriteLine($"{name} Human resource training unit");
        }
    }
}
