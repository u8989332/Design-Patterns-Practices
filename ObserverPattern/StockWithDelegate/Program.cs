using System;

namespace StockWithDelegate
{
    class Program
    {
        static void Main(string[] args)
        {
            Boss myBoss = new Boss();
            StockObserver employee1 = new StockObserver("John", myBoss);
            NBAObserver employee2 = new NBAObserver("Tom", myBoss);

            myBoss.Update += employee1.CloseStockMarket;
            myBoss.Update += employee2.CloseNBADirectSeeding;

            myBoss.SubjectState = "I will go into the office!";
            myBoss.Notify();

            Console.Read();
        }
    }
}
