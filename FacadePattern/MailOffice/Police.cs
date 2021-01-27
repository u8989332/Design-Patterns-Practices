using System;

namespace MailOffice
{
    public class Police
    {
        public void CheckLetter(ILetterProcess letterProcess)
        {
            Console.WriteLine(letterProcess + " letter has been checked");
        }
    }
}
