using NUnit.Framework;
using BuildTest;

namespace Test
{
    [TestFixture()]
    class MyClassTest
    {
        [Test()]
        public void MultiplyTest()
        {
            var mc = new MyClass();
            Assert.AreEqual(0, mc.Multiply(1, 0));
            Assert.AreEqual(0, mc.Multiply(0, 1));
            Assert.AreEqual(1, mc.Multiply(1, 1));
            Assert.AreEqual(10, mc.Multiply(5, 2));
        }
    }
}

