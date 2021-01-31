using System.Collections.Generic;

namespace NumberDisplay
{
    abstract class NumberGenerator
    {
        private IList<Observer> observers = new List<Observer>();
        public void AddObserver(Observer observer)
        {
            this.observers.Add(observer);
        }

        public void DeleteObserver(Observer observer)
        {
            this.observers.Remove(observer);
        }

        public void NotifyObservers()
        {
            foreach(Observer o in observers)
            {
                o.Update(this);
            }
        }

        public abstract int GetNumber();
        public abstract void Execute();
    }
}