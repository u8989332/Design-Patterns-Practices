namespace AbstractFactoryWithTypeMapper
{
    public interface IAbstractFactory
    {
        T Create<T>() where T : class;
    }
}