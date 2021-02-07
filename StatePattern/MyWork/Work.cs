namespace MyWork
{
    class Work
    {
        private State current;
        public Work()
        {
            current = new ForenoonState();
        }

        public double Hour { get; set; }
        public bool TaskFinished { get; set; }
        public void SetState(State s)
        {
            current = s;
        }

        public void WriteProgram()
        {
            current.WriteProgram(this);
        }
    }
}