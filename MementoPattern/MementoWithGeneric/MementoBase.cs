namespace MementoWithGeneric
{
    public abstract class MementoBase<T> : IMemento<T>
        where T : IState
    {
        public virtual T State { get; set; }
    }
}