using System.Collections.Generic;

namespace StockWithObserver
{
    class Boss : Subject
    {
        private IList<Observer> observers = new List<Observer>();
        private string action;
        public string SubjectState 
        { 
            get => action; 
            set => action = value; 
        }

        public void Attach(Observer observer)
        {
            observers.Add(observer);
        }

        public void Detach(Observer observer)
        {
            observers.Remove(observer);
        }

        public void Notify()
        {
            foreach(Observer o in observers)
            {
                o.Update();
            }
        }
    }
}
