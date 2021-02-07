using System;

namespace MyLift
{
    class Program
    {
        static void Main(string[] args)
        {
            Context context = new Context();
            context.LiftStete = Context.closingState;
            context.Open();
            context.Close();
            context.Run();
            context.Stop();
            Console.Read();
        }
    }
}
