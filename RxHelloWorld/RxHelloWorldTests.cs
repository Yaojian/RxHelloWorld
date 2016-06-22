using System;
using ReactiveUI;
using NUnit.Framework;
using RxFormsLib;
using System.Reactive;

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
        public void Create_ReactiveObject_should_be_successful()
        {
            var model = new HelloWorldModel();
            Assert.NotNull(model);
        }

        [Test]
        public void Create_HelloWorldInLibModel_should_be_successful()
        {
            var model = new HelloWorldInLibModel();
            Assert.NotNull(model);

            //model.Say.Execute(Unit.Default);
        }
    }

    public class HelloWorldModel : ReactiveObject
    {
    }
}

