using System;

namespace StockWithObserver
{
    class NBAObserver : Observer
    {
        public NBAObserver(string name, Subject sub) : base(name, sub)
        {
        }

        public override void Update()
        {
            Console.WriteLine($"{sub.SubjectState} {name} closes the NBA channel, and continue to work!", sub.SubjectState, name);
        }
    }
}