namespace MementoWithEncapsulation
{
    public class Originator
    {
        public string State { get; set; }    
        public IMemento CreateMemento()
        {
            return new Memento(this.State);
        }  

        public void RestoreMemento(IMemento memento)
        {
            State = ((Memento)memento).State;
        }

        private class Memento : IMemento
        {
            public Memento(string state)
            {
                State = state;
            } 

            public string State { get; set; }
        }
    }
}