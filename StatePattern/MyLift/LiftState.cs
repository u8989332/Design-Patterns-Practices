namespace MyLift
{
    abstract class LiftState
    {
        protected Context context;
        public void SetContext(Context _context)
        {
            this.context = _context;
        }

        public abstract void Open();
        public abstract void Close();
        public abstract void Run();
        public abstract void Stop();
    }
}
