using NUnit.Framework;

namespace MementoInStack.Tests
{
    public class Tests
    {
        [Test]
        public void Test1()
        {
            Originator ori = new Originator();
            ori.SaveCheckpoint(); // x = 0, y = 0

            ori.IncreaseY();
            ori.DecreaseX();
            ori.SaveCheckpoint(); // x = -1, y = 1

            ori.UpdateX(2);
            ori.SaveCheckpoint(); // x = 2, y = 1
             
            ori.UpdateX(3);
            ori.IncreaseY(); // x = 3, y = 1

            Assert.AreEqual(3, ori.Current.X);
            Assert.AreEqual(2, ori.Current.Y);

            ori.Undo();
            Assert.AreEqual(2, ori.Current.X);
            Assert.AreEqual(1, ori.Current.Y);

            ori.Undo();
            Assert.AreEqual(-1, ori.Current.X);
            Assert.AreEqual(1, ori.Current.Y);
        }
    }
}