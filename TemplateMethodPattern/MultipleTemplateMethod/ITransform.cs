namespace MultipleTemplateMethod
{
    public interface ITransform
    {
        string Transform(string data);
        bool Parse(string data);
        string Replace(string data);
    }
}
