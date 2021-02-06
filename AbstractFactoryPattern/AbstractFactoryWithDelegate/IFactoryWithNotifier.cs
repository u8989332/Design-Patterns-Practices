namespace AbstractFactoryWithDelegate
{
    public interface IFactoryWithNotifier : IFactory
    {
        void Create(ObjectCreateHandler<IProduct> callback);
    }
}