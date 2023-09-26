using NUnit.Framework;

namespace LiteViewTest
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
            LiteViewGL.ImagePositioner ip = new LiteViewGL.ImagePositioner();
            Assert.Pass();
        }
    }
}