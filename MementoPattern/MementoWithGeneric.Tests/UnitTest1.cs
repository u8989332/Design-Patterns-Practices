using NUnit.Framework;

namespace MementoWithGeneric.Tests
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
            Originator ori = new Originator();
            Assert.AreEqual(0, ori.Current.Y);
            Assert.AreEqual(0, ori.Current.X);

            IMemento<Position> m1 = ori.Memento;

            ori.IncreaseY();
            ori.DecreaseX();
            Assert.AreEqual(1, ori.Current.Y);
            Assert.AreEqual(-1, ori.Current.X);

            ori.Memento = m1;
            Assert.AreEqual(0, ori.Current.Y);
            Assert.AreEqual(0, ori.Current.X);
        }
    }
}