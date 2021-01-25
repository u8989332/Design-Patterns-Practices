namespace MultipleTemplateMethod
{
    public interface ISetter
    {
        string Append(string data);
        bool CheckHeader(string data);
        bool CheckTailer(string data);
    }
}
