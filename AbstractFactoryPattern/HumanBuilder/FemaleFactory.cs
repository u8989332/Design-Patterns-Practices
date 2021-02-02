namespace HumanBuilder
{
    class FemaleFactory : IHumanFactory
    {
        public AbstractHuman CreateBlackHuman()
        {
            return new FemaleBlackHuman();
        }

        public AbstractHuman CreateWhiteHuman()
        {
            return new FemaleWhiteHuman();
        }

        public AbstractHuman CreateYellowHuman()
        {
            return new FemaleYellowHuman();
        }
    }
}
