namespace StockWithDelegate
{
    delegate void EventHandler();
    class Boss : Subject
    {
        private string action;
        public string SubjectState
        {
            get => action;
            set => action = value;
        }

        public event EventHandler Update = delegate { };

        public void Notify()
        {
            Update();
        }
    }
}
