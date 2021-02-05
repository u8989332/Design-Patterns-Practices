namespace AbstractFactoryWithAssemblerMechanism
{
    public class ConcreteYTypeMapper : TypeMapperBase
    {
        public ConcreteYTypeMapper()
        {
            base.Add(typeof(IProductYA), typeof(ProductYA1));
            base.Add(typeof(IProductYB), typeof(ProductYB1));
            base.Add(typeof(IProductYC), typeof(ProductYC1));
        }
    }
}