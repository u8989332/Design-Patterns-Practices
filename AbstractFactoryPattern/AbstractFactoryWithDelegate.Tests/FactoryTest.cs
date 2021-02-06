using NUnit.Framework;

namespace AbstractFactoryWithDelegate.Tests
{
    public class FactoryTest
    {
        [Test]
        public void Test1()
        {
            IFactoryWithNotifier factory = new ConcreteFactory();
            Subscribe subscribe = new Subscribe();
            ObjectCreateHandler<IProduct> callback = new ObjectCreateHandler<IProduct>(subscribe.SetProduct);
            Assert.IsNull(subscribe.GetProduct());
            factory.Create(callback);
            Assert.IsNotNull(subscribe.GetProduct());
        }

        class ConcreteProduct : IProduct
        {

        }

        class ConcreteFactory : IFactoryWithNotifier
        {
            public void Create(ObjectCreateHandler<IProduct> callback)
            {
                IProduct product = Create();
                callback(product);
            }

            public IProduct Create()
            {
                return new ConcreteProduct();
            }
        }

        class Subscribe
        {
            private IProduct product;
            public void SetProduct(IProduct product)
            {
                this.product = product;
            }

            public IProduct GetProduct()
            {
                return this.product;
            }
        }
    }
}