namespace MementoInStack
{
    using System.Collections.Generic;

    public abstract class OriginatorBase<T>
        where T : IState
    {
        protected T state;
        protected class InternalMemento<T2> : IMemento<T2>
            where T2 : IState
        {
            public T2 State { get; set; }
        }

        protected virtual IMemento<T> CreateMemento()
        {
            IMemento<T> m = new InternalMemento<T>();
            m.State = this.state;
            return m;
        }

        private readonly Stack<IMemento<T>> stack = new Stack<IMemento<T>>();

        public virtual void SaveCheckpoint()
        {
            this.stack.Push(this.CreateMemento());
        }

        public virtual void Undo()
        {
            if (this.stack.Count == 0)
            {
                return;
            }

            IMemento<T> m = this.stack.Pop();
            this.state = m.State;
        }
    }
}