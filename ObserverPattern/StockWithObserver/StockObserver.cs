using System;

namespace StockWithObserver
{
    class StockObserver : Observer
    {
        public StockObserver(string name, Subject sub) : base(name, sub)
        {
        }

        public override void Update()
        {
            Console.WriteLine($"{sub.SubjectState} {name} closes the stock panel, and continue to work!");
        }
    }
}