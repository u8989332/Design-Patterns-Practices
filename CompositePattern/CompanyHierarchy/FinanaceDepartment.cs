using System;

namespace CompanyHierarchy
{
    class FinanaceDepartment : Company
    {
        public FinanaceDepartment(string name) : base(name)
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
            Console.WriteLine($"{name} Corporation Finance management unit");
        }
    }
}
