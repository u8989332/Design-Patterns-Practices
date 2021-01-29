namespace BuilderWithAttribute
{
    public interface IBuilder<T> where T : class, new()
    {
        T BuildUp();
    }
}
