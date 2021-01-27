namespace MailOffice
{
    public interface ILetterProcess
    {
        void WriteContext(string context);
        void FillEnvelope(string address);
        void LetterIntoEnvelope();
        void SendLetter();
    }
}