using NUnit.Framework;

namespace DbAdapterWithFactory.Tests
{
    public class AdapterTests
    {

        [Test]
        public void Test1()
        {
            DatabaseAdapterFactory factory = new DatabaseAdapterFactory();
            IDatabaseAdapter adapter = factory.Create("oracle");
            Assert.AreEqual("oracle", adapter.ProviderName);
            Assert.IsInstanceOf(typeof(OracleAdapter), adapter);
        }
    }
}