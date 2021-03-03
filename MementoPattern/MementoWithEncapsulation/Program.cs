using System;

namespace MementoWithEncapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            Originator ori = new Originator();
            Caretaker caretaker = new Caretaker();
            ori.State = "Happy";
            Console.WriteLine(ori.State);

            caretaker.Memento = ori.CreateMemento();
            ori.State = "Sad";
            Console.WriteLine(ori.State);

            ori.RestoreMemento(caretaker.Memento);
            Console.WriteLine(ori.State);

            Console.Read();
        }
    }
}
