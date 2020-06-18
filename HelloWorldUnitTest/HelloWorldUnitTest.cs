using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HelloWorld;

namespace HelloWorldUnitTest
{
    [TestClass]
    public class HelloWorldUnitTest
    {
        [TestMethod]
        public void SayHelloWorld()
        {
            var world = new World();
            Assert.AreEqual("Hello World", world.SayHelloWorld());
        }
    }
}
