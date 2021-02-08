using System;

namespace CompanyHierarchy
{
    class Program
    {
        static void Main(string[] args)
        {
            ConcreteCompany root = new ConcreteCompany("Taiwan Taipei headquarter");
            root.Add(new HRDepartment("Headquarter HR"));
            root.Add(new FinanaceDepartment("Headquarter Finanace"));

            ConcreteCompany comp = new ConcreteCompany("Taiwan Tainan branch");
            comp.Add(new HRDepartment("Tainan HR"));
            comp.Add(new FinanaceDepartment("Tainan Finanace"));
            root.Add(comp);

            ConcreteCompany comp1 = new ConcreteCompany("Taiwan Pingtung Office");
            comp1.Add(new HRDepartment("Pingtung HR"));
            comp1.Add(new FinanaceDepartment("Pingtung Finanace"));
            comp.Add(comp1);

            ConcreteCompany comp2 = new ConcreteCompany("Taiwan Taichung Office");
            comp2.Add(new HRDepartment("Taichung HR"));
            comp2.Add(new FinanaceDepartment("Taichung Finanace"));
            comp.Add(comp2);

            Console.WriteLine("Hierarcy");
            root.Display(1);

            Console.WriteLine("Duty");
            root.LineOfDuty();

            Console.Read();
        }
    }
}
