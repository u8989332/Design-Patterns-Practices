namespace StockWithDelegate
{
    abstract class Observer
    {
        protected string name;
        protected Subject sub;
        public Observer(string name, Subject sub)
        {
            this.name = name;
            this.sub = sub;
        }
    }
}
