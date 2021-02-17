using System.Collections.Generic;

namespace ManAndWoman
{
    class ObjectStructure
    {
        private IList<Person> elements = new List<Person>();
        
        public void Attach(Person element)
        {
            elements.Add(element);
        }

        public void Detach(Person element)
        {
            elements.Remove(element);
        }

        public void Display(Action visitor)
        {
            foreach(Person e in elements)
            {
                e.Accept(visitor);
            }
        }
    }
}
