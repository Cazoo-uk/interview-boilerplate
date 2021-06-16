using NUnit.Framework;
using Interview;

namespace Interview
{
    [TestFixture]
    public class TestClass
    {
        private Class classInstance;

        [SetUp]
        public void SetUp()
        {
            classInstance = new Class();
        }

        [Test]
        public void TestMethod()
        {
            var result = classInstance.Method();

            Assert.IsTrue(result);
        }
    }
}