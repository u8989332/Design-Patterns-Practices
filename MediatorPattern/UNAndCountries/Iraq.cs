using System;

namespace UNAndCountries
{
    class Iraq : Country
    {
        public Iraq(UnitedNations mediator) : base(mediator)
        {
        }

        public void Declare(string message)
        {
            mediator.Declare(message, this);
        }

        public void GetMessage(string message)
        {
            Console.WriteLine("Iraq gets the message: " + message);
        }
    }
}