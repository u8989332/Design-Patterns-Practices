namespace MementoWithGeneric
{
    public interface IMemento<T> where T : IState
    {
         T State { get; set; }
    }
}