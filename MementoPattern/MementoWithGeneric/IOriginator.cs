namespace MementoWithGeneric
{
    public interface IOriginator<T, M>
        where T : IState
        where M : IMemento<T>, new()
    {
         IMemento<T> Memento { get; set; }
    }
}