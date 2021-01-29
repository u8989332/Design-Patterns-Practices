using System;

namespace CarModel
{
    class Program
    {
        static void Main(string[] args)
        {
            Director director = new Director();
            for(int i = 0; i < 3; ++i)
            {
                director.GetABexzModel().Run();
            }

            for (int i = 0; i < 3; ++i)
            {
                director.GetBBexzModel().Run();
            }

            for (int i = 0; i < 3; ++i)
            {
                director.GetCBXWModel().Run();
            }

            for (int i = 0; i < 3; ++i)
            {
                director.GetDBXWModel().Run();
            }
        }
    }
}
