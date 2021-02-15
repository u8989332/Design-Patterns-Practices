using System;

namespace UNAndCountries
{
    class USA : Country
    {
        public USA(UnitedNations mediator) : base(mediator)
        {
        }

        public void Declare(string message)
        {
            mediator.Declare(message, this);
        }

        public void GetMessage(string message)
        {
            Console.WriteLine("USA gets the message: " + message);
        }
    }
}