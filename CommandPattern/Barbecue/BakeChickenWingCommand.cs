namespace Barbecue
{
    class BakeChickenWingCommand : Command
    {
        public BakeChickenWingCommand(Barbecuer receiver) : base(receiver)
        {
        }

        public override void ExecuteCommand()
        {
            receiver.BakeChickenWing();
        }
    }
}
