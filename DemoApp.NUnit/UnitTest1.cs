using NUnit.Framework;

namespace DemoApp.NUnit
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestAdd()
        {
            var expectedResult = 2;
            var actualResult = DemoApp.Library.Add(1, 1);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void TestMultiply()
        {
            var expectedResult = 15;
            var actualResult = DemoApp.Library.Multiply(5, 3);
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}