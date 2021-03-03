namespace MementoInStack
{
    public interface IMemento<T> where T : IState
    {
         T State { get; set; }
    }
}