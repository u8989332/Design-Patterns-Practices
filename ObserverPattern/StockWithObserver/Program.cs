using System;

namespace StockWithObserver
{
    class Program
    {
        static void Main(string[] args)
        {

            Boss myBoss = new Boss();
            Observer employee1 = new StockObserver("John", myBoss);
            Observer employee2 = new NBAObserver("Tom", myBoss);
            Observer employee3 = new StockObserver("Mary", myBoss);


            myBoss.Attach(employee1);
            myBoss.Attach(employee2);
            myBoss.Attach(employee3);


            myBoss.Detach(employee3);

            myBoss.SubjectState = "I will go into the office!";
            myBoss.Notify();

            Console.Read();
        }
    }
}
