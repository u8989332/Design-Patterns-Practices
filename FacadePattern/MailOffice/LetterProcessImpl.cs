using System;

namespace MailOffice
{
    public class LetterProcessImpl : ILetterProcess
    {
        public void FillEnvelope(string address)
        {
            Console.WriteLine("Write receiver address: " + address);
        }

        public void LetterIntoEnvelope()
        {
            Console.WriteLine("Put the letter into the envelope: ");
        }

        public void SendLetter()
        {
            Console.WriteLine("Send the letter");
        }

        public void WriteContext(string context)
        {
            Console.WriteLine("Mail context: " + context);
        }
    }
}