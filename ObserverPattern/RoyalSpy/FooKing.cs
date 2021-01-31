using System;
using System.Collections.Generic;

namespace RoyalSpy
{
    class FooKing : Observable
    {
        private IList<Observer> observerlist = new List<Observer>();
        public void AddObserver(Observer observer)
        {
            this.observerlist.Add(observer);
        }

        public void DeleteObserver(Observer observer)
        {
            this.observerlist.Remove(observer);
        }

        public void NotifyObservers(string context)
        {
            foreach(var o in observerlist)
            {
                o.Update(context);
            }
        }

        public void HaveBreakfast()
        {
            Console.WriteLine("FooKing : I start eating...");
            this.NotifyObservers("FooKing is eating");
        }

        public void HaveFun()
        {
            Console.WriteLine("FooKing : I start having fun...");
            this.NotifyObservers("FooKing is having fun");
        }
    }
}