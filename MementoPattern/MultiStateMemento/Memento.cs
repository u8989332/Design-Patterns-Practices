using System.Collections.Generic;

namespace MultiStateMemento
{
    public class Memento
    {
        public IDictionary<string, object> StateMap { get;set; }

        public Memento(IDictionary<string, object> stateMap)
        {
            StateMap = stateMap;
        }
    }
}