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
        public void NUnit_should_be_launched_succeed()
        {
            Console.WriteLine("NUnit is launched successfully.");
            Assert.IsTrue(true);
        }

        [Test]
        public void Splat_InUnitTestRunner_should_return_true()
        {
            var flag = Splat.ModeDetector.InUnitTestRunner();
            Assert.IsTrue(flag, "InUnitTestRunner should be true.");
        }

        [Test]
        public void Create_HelloWorldModel_should_returns_new_instance()
        {
            var model = new HelloWorldModel();
            Assert.NotNull(model);
        }

        [Test]
        public void Create_HelloWorldInLibModel_should_be_succeed()
        {
            var model = new HelloWorldInLibModel();
            Assert.NotNull(model);
        }
    }
}

