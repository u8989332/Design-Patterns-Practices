using System;

namespace RoyalSpy
{
    class Spy1 : Observer
    {
        public void Update(string context)
        {
            Console.WriteLine("Spy1: I find FooKing is acting, so I will report to BarKing");
            ReportToBarKing(context);
            Console.WriteLine("Spy1: Report completed");
        }

        private void ReportToBarKing(string context)
        {
            Console.WriteLine("Spy1: My lord BarKing, FooKing is acting-->" + context);
        }
    }
}