namespace MailOffice
{
    public class MailPostOffice
    {
        private ILetterProcess letterProcess = new LetterProcessImpl();
        private Police police = new Police();
        public void SendLetter(string context, string address)
        {
            letterProcess.WriteContext(context);
            letterProcess.FillEnvelope(address);
            police.CheckLetter(letterProcess);
            letterProcess.LetterIntoEnvelope();
            letterProcess.SendLetter();
        }
    }
}
