using System;

namespace Phone
{
    class Program
    {
        static void Main(string[] args)
        {
            HandsetBrand hb;
            hb = new HandsetBrandN();

            hb.SetHandsetSoft(new HandsetGame());
            hb.Run();


            hb.SetHandsetSoft(new HandsetAddressList());
            hb.Run();

            hb = new HandsetBrandM();

            hb.SetHandsetSoft(new HandsetGame());
            hb.Run();


            hb.SetHandsetSoft(new HandsetAddressList());
            hb.Run();

            Console.Read();
        }
    }
}
