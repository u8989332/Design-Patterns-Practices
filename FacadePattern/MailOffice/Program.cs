using System;

namespace MailOffice
{
    class Program
    {
        static void Main(string[] args)
        {
            MailPostOffice myMailPostOffice = new MailPostOffice();
            string context = "Happy new year";
            string address = "Yellow Road No. 5566, Tom Province";
            myMailPostOffice.SendLetter(context, address);

            Console.Read();
        }
    }
}
