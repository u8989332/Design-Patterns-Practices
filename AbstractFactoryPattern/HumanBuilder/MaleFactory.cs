namespace HumanBuilder
{
    class MaleFactory : IHumanFactory
    {
        public AbstractHuman CreateBlackHuman()
        {
            return new MaleBlackHuman();
        }

        public AbstractHuman CreateWhiteHuman()
        {
            return new MaleWhiteHuman();
        }

        public AbstractHuman CreateYellowHuman()
        {
            return new MaleYellowHuman();
        }
    }
}
