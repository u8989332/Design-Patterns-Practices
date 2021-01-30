using System;

namespace StockWithDelegate
{
    class NBAObserver : Observer
    {
        public NBAObserver(string name, Subject sub) : base(name, sub)
        {
        }

        public void CloseNBADirectSeeding()
        {
            Console.WriteLine($"{sub.SubjectState} {name} closes the NBA channel, and continue to work");
        }
    }
}
