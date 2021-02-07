namespace PlayerTranslator
{
    class Translator : Player
    {
        private ForeignCenter fc = new ForeignCenter();
        public Translator(string name) : base(name)
        {
            fc.name = name;
        }
        
        public override void Attack()
        {
            fc.FCAttack();
        }

        public override void Defense()
        {
            fc.FCDefense();
        }
    }
}
