using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace AbstractFactoryWithTypeMapper.Tests
{
    public class FactoryTest
    {

        IAbstractFactory AssemblyFactory()
        {
            IDictionary<Type, Type> dic = new Dictionary<Type, Type>();
            dic.Add(typeof(IProductA), typeof(ProductA1));
            dic.Add(typeof(IProductB), typeof(ProductB1));
            return new ConcreteFactory(dic);
        }

        [Test]
        public void Test1()
        {
            IAbstractFactory factory = AssemblyFactory();
            IProductA productA = factory.Create<IProductA>();
            IProductB productB = factory.Create<IProductB>();

            Assert.IsInstanceOf(typeof(ProductA1), productA);
            Assert.IsInstanceOf(typeof(ProductB1), productB);
        }
    }
}