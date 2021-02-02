using System;

namespace HumanBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            IHumanFactory maleHumanFactory = new MaleFactory();
            IHumanFactory femaleHumanFactory = new FemaleFactory();

            AbstractHuman maleYellowHuman = maleHumanFactory.CreateYellowHuman();
            AbstractHuman femaleBlackHuman = femaleHumanFactory.CreateBlackHuman();

            maleYellowHuman.GetColor();
            maleYellowHuman.GetSex();
            maleYellowHuman.Talk();

            femaleBlackHuman.GetColor();
            femaleBlackHuman.GetSex();
            femaleBlackHuman.Talk();

            Console.Read();
        }
    }
}
