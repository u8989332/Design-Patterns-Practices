using System;

namespace GamePlayer
{
    class Program
    {
        static void Main(string[] args)
        {
            Role myPlayer = new Role();
            myPlayer.GetInitState();
            myPlayer.StateDisplay();

            RoleStateCatetaker stateAdmin = new RoleStateCatetaker();
            stateAdmin.Memento = myPlayer.SaveState();

            myPlayer.Fight();
            myPlayer.StateDisplay();

            myPlayer.RecoveryState(stateAdmin.Memento);
            myPlayer.StateDisplay();

            Console.Read();
        }
    }
}
