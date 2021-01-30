namespace StockWithDelegate
{
    interface Subject
    {
        void Notify();
        string SubjectState { get; set; }
    }
}