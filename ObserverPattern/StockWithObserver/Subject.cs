namespace StockWithObserver
{
    interface Subject
    {
        void Attach(Observer observer);
        void Detach(Observer observer);
        void Notify();
        string SubjectState { get; set; }
    }
}
