namespace AbstractFactoryWithAssemblerMechanism
{
    public interface IAbstractFactory
    {
        T Create<T>();
    }
}