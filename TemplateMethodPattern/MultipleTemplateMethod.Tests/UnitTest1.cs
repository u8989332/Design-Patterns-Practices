using NUnit.Framework;

namespace MultipleTemplateMethod.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            ITransform transform = new DataBroker();
            string data = "1X2X";
            Assert.AreEqual("1Y2Y", transform.Transform(data));

            ISetter setter = new DataBroker();
            data = "H:123";
            Assert.AreEqual("H:123:T", setter.Append(data));
        }
    }
}