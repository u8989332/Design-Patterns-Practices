namespace AbstractFactoryWithAssemblerMechanism
{
    public interface IAbstractFactoryWithTypeMapper : IAbstractFactory
    {
        TypeMapperBase Mapper { get; set; }
    }
}