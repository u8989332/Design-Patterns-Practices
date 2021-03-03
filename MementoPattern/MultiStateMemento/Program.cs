using System;

namespace MultiStateMemento
{
    class Program
    {
        static void Main(string[] args)
        {
            Originator ori = new Originator();
            Caretaker caretaker = new Caretaker();

            // initialize
            ori.State1 = "Happy";
            ori.State2 = "Strong";
            ori.State3 = "Tall";
            Console.WriteLine("Init state: " + ori.ToString());

            // create a memento
            caretaker.Memento = ori.CreateMemento();

            // modify
            ori.State1 = "Sad";
            ori.State2 = "Weak";
            ori.State3 = "Short";
            Console.WriteLine("Modify state: " + ori.ToString());

            // restore
            ori.RestoreMemento(caretaker.Memento);
            Console.WriteLine("Restore state: " + ori.ToString());

            Console.Read();
        }
    }
}
