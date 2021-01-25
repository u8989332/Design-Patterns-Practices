namespace CarModel
{
    public abstract class Sedan
    {
        protected abstract void Start();
        protected abstract void Stop();
        protected abstract void Alarm();
        protected abstract void EngineBoom();
        public void Run()
        {
            this.Start();
            this.EngineBoom();
            if (this.IsAlarm())
            {
                this.Alarm();
            }

            this.Stop();
        }

        protected virtual bool IsAlarm()
        {
            return true;
        }
    }
}
