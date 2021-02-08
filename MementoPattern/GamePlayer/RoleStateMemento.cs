namespace GamePlayer
{
    class RoleStateMemento
    {
        public RoleStateMemento(int vitality, int attack, int defense)
        {
            this.Vitality = vitality;
            this.Attack = attack;
            this.Defense = defense;
        }

        public int Vitality { get ; set; }
        public int Attack { get; set; }
        public int Defense { get; set; }
    }
}