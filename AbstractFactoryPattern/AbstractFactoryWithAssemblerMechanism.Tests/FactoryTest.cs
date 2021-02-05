using NUnit.Framework;

namespace AbstractFactoryWithAssemblerMechanism.Tests
{
    public class FactoryTest
    {

        [Test]
        public void Test1()
        {
            IAbstractFactoryWithTypeMapper factory = new ConcreteFactoryX();
            AssemblyMechanism.Assembly(factory);
            IProductXB productXB = factory.Create<IProductXB>();
            Assert.IsInstanceOf(typeof(ProductXB1), productXB);

            factory = new ConcreteFactoryY();
            AssemblyMechanism.Assembly(factory);
            IProductYC productYC = factory.Create<IProductYC>();
            Assert.IsInstanceOf(typeof(ProductYC1), productYC);
        }
    }
}