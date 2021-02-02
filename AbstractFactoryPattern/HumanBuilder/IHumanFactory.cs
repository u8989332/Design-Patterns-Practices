namespace HumanBuilder
{
    interface IHumanFactory
    {
        AbstractHuman CreateYellowHuman();
        AbstractHuman CreateBlackHuman();
        AbstractHuman CreateWhiteHuman();
    }
}
