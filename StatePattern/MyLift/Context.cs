namespace MyLift
{
    class Context
    {
        public readonly static OpenningState openningState = new OpenningState();
        public readonly static ClosingState closingState = new ClosingState();
        public readonly static RunningState runningState = new RunningState();
        public readonly static StoppingState stoppingState = new StoppingState();

        private LiftState liftState;
        public LiftState LiftStete
        {
            get
            {
                return liftState;
            }

            set
            {
                liftState = value;
                liftState.SetContext(this);
            }
        }

        public void Open()
        {
            this.liftState.Open();
        }

        public void Close()
        {
            this.liftState.Close();
        }

        public void Run()
        {
            this.liftState.Run();
        }

        public void Stop()
        {
            this.liftState.Stop();
        }
    }
}