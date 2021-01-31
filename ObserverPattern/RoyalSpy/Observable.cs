namespace RoyalSpy
{
    interface Observable
    {
        public void AddObserver(Observer observer);
        public void DeleteObserver(Observer observer);
        public void NotifyObservers(string context);
    }
}
