using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestPlatform.UnitTestFramework;
using ButtonBinding;

namespace MeineTests {
    [TestClass]
    public class MainPageViewModelTests {
        [TestMethod]
        [TestCategory("Kategorie2")]
        public void ConstructorTest() {
            MainPageViewModel vm = new MainPageViewModel();
            Assert.IsNotNull(vm.SayHelloCommand);
        }

        [TestMethod]
        [TestCategory("Kategorie1")]
        public void MessageFireEventTest() {
            MainPageViewModel vm = new MainPageViewModel();
            string message = "Hallo Test";
            bool eventFired = false;
            vm.PropertyChanged += (o, e) => eventFired = e.PropertyName == "Message";
            vm.Message = message;
            Assert.IsTrue(eventFired);
            Assert.AreEqual(message, vm.Message);
        }

        [TestMethod]
        public void SayHelloCommandTest() {
            MainPageViewModel vm = new MainPageViewModel();
            Assert.IsFalse(vm.SayHelloCommand.CanExecute(null));
            vm.Text = "Wert";
            Assert.IsTrue(vm.SayHelloCommand.CanExecute(null));
            vm.SayHelloCommand.Execute(null);
            Assert.AreEqual("Hallo Wert", vm.Message);
        }

        [TestMethod]
        [TestCategory("Kategorie1")]
        public void FailTest() {
            Assert.Fail();
        }
    }
}
