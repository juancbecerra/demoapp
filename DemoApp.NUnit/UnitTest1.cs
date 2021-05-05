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
        public void Test1()
        {
            var expectedResult = 2;
            var actualResult = DemoApp.Library.Add(1, 1);
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}