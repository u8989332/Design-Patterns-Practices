using System;
using System.Collections.Generic;

namespace CompanyHierarchy
{
    class ConcreteCompany : Company
    {
        private List<Company> children = new List<Company>();
        public ConcreteCompany(string name) : base(name)
        {

        }

        public override void Add(Company c)
        {
            this.children.Add(c);
        }
        public override void Remove(Company c)
        {
            this.children.Remove(c);
        }
        public override void Display(int depth)
        {
            Console.WriteLine(new string('-', depth) + name);
            foreach (Company item in this.children)
            {
                item.Display(depth + 2);
            }
        }

        public override void LineOfDuty()
        {
            foreach (Company item in this.children)
            {
                item.LineOfDuty();
            }
        }
    }
}
