namespace Display
{
    public abstract class AbstractDisplay
    {
        protected abstract void Open();
        protected abstract void Print();
        protected abstract void Close();
        public virtual void Display()
        {
            Open();
            for(int i = 0; i < 5;++i)
            {
                Print();
            }
            Close();
        }
    }
}
