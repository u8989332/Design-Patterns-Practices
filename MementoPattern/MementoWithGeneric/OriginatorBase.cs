using System;

namespace MementoWithGeneric
{
    public abstract class OriginatorBase<T, M> : IOriginator<T, M>
        where T : IState
        where M : IMemento<T>, new()
    {
        protected T state;
        public virtual IMemento<T> Memento
        {
            get
            {
                M m = new M();
                m.State = this.state;
                return m;
            }
            set
            {
                if(value == null)
                {
                    throw new ArgumentNullException();
                }
                this.state = value.State;
            }
        }
    }
}