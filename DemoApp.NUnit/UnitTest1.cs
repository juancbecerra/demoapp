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

        [Test]
        public void TestSubtract()
        {
            var expectedResult = 15;
            var actualResult = DemoApp.Library.Subtract(20, 5);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void TestDivision()
        {
            var expectedResult = 10;
            var actualResult = DemoApp.Library.Divide(100, 10);
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}