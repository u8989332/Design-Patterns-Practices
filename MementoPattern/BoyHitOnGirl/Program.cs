using System;

namespace BoyHitOnGirl
{
    class Program
    {
        static void Main(string[] args)
        {
            Boy boy = new Boy();
            Caretaker caretaker = new Caretaker();
            boy.State = "Great mind";
            Console.WriteLine("===Currently boy's state");
            Console.WriteLine(boy.State);
            caretaker.memento = boy.CreateMemento();

            // after hitting on a girl

            boy.ChangeState();
            Console.WriteLine("====After hitting on a girl, the boy's state");
            Console.WriteLine(boy.State);

            // restore the mind
            boy.RestoreMemento(caretaker.memento);
            Console.WriteLine("===After restoring, currently boy's state");
            Console.WriteLine(boy.State);

        }
    }
}
