namespace BoyHitOnGirl
{
    class Boy
    {
        public string State { get; set; }

        public void ChangeState()
        {
            State = "Mind is bad...";
        }

        public Memento CreateMemento()
        {
            return new Memento(this.State);
        }

        public void RestoreMemento(Memento memento)
        {
            State = memento.State;
        }
    }
}
