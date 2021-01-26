using System;

namespace BuySellStock
{
    public class Program
    {
        static void Main(string[] args)
        {
            Fund myFund = new Fund();
            myFund.BuyFund();
            myFund.SellFund();
            Console.Read();
        }
    }
}
