using System;
using ReactiveUI;
using NUnit.Framework;

namespace RxHelloWorld
{
    [TestFixture]
    public class RxHelloWorldTests
    {
        [Test]
        public void NUnit_should_be_launched_successfully()
        {
            Console.WriteLine("NUnit is launched successfully.");
            Assert.IsTrue(true);
        }

        [Test]
        public void Create_ReactiveObject_should_be_successfully()
        {
            var model = new HelloWorldModel();
            Assert.NotNull(model);
        }
    }

    public class HelloWorldModel : ReactiveObject
    {
    }
}

