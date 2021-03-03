namespace MultiStateMemento
{
    public class Originator
    {
        public string State1 { get; set; }
        public string State2 { get; set; }
        public string State3 { get; set; }
        public Memento CreateMemento()
        {
            return new Memento(ModelUtilities.BackupProperties(this));
        }
        public void RestoreMemento(Memento memento)
        {
            ModelUtilities.RestoreProperties(this, memento.StateMap);
        }

        public override string ToString()
        {
            return $"State1 = {State1}, State2 = {State2}, State3 = {State3}";
        }
    }
}