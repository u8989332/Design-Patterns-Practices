using System;
using System.Collections.Generic;

namespace Barbecue
{
    class Waiter
    {
        private IList<Command> orders = new List<Command>();

        public void SetOrder(Command command)
        {
            if(command is BakeChickenWingCommand)
            {
                Console.WriteLine("Waiter: no chicken wings....");
            }
            else
            {
                orders.Add(command);
                Console.WriteLine("Add order: " + command.ToString() + ", Time: " + DateTime.Now.ToString());
            }
        }

        public void CancelOrder(Command command)
        {
            orders.Remove(command);
            Console.WriteLine("Remove order: " + command.ToString() + ", Time: " + DateTime.Now.ToString());
        }

        public void Notify()
        {
            foreach(Command cmd in orders)
            {
                cmd.ExecuteCommand();
            }
        }
    }
}
