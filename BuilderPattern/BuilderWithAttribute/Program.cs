using System;

namespace BuilderWithAttribute
{
    class Program
    {
        static void Main(string[] args)
        {
            Builder<Car> builder = new Builder<Car>();
            Car car = builder.BuildUp();
            Console.WriteLine(car.Log.Count); // 3
            Console.WriteLine(car.Log[0]); // body
            Console.WriteLine(car.Log[2]); // wheel
            Console.Read();
        }
    }
}
