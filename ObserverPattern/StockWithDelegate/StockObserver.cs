using System;

namespace StockWithDelegate
{
    class StockObserver : Observer
    {
        public StockObserver(string name, Subject sub) : base(name, sub)
        {
        }

        public void CloseStockMarket()
        {
            Console.WriteLine($"{sub.SubjectState} {name} closes the stock panel, and continue to work!");
        }
    }
}
