using System;

namespace BuySellStock
{
    public class Fund
    {
        Stock1 st1;
        NationalDebt1 nd1;
        Realty1 rt1;
        public Fund()
        {
            st1 = new Stock1();
            nd1 = new NationalDebt1();
            rt1 = new Realty1();
        }

        public void BuyFund()
        {
            st1.Buy();
            nd1.Buy();
            rt1.Buy();
        }

        public void SellFund()
        {
            st1.Sell();
            nd1.Sell();
            rt1.Sell();
        }
    }
}
