using System;

namespace GamePlayer
{
    class Role
    {
        public int Vitality { get; set; }
        public int Attack { get; set; }
        public int Defense { get; set; }
        public void StateDisplay()
        {
            Console.WriteLine("Current player's state:");
            Console.WriteLine($"Vitality: {this.Vitality}");
            Console.WriteLine($"Attack: {this.Attack}");
            Console.WriteLine($"Defense: {this.Defense}");
        }

        public void GetInitState()
        {
            this.Vitality = 100;
            this.Attack = 100;
            this.Defense = 100;
        }

        public void Fight()
        {
            this.Vitality = 0;
            this.Attack = 0;
            this.Defense = 0;
        }

        public RoleStateMemento SaveState()
        {
            return (new RoleStateMemento(Vitality, Attack, Defense));
        }

        public void RecoveryState(RoleStateMemento memento)
        {
            this.Vitality = memento.Vitality;
            this.Attack = memento.Attack;
            this.Defense = memento.Defense;
        }
    }
}
