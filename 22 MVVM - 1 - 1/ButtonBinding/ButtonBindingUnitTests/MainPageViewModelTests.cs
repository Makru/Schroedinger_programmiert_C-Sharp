using System;
using Microsoft.VisualStudio.TestPlatform.UnitTestFramework;
using ButtonBinding;

namespace ButtonBindingUnitTests {
    [TestClass]
    public class MainPageViewModelTests {
        [TestMethod]
        public void ConstructorTest() {
            MainPageViewModel vm = new MainPageViewModel();
            Assert.IsNotNull(vm.SayHelloCommand);
        }

        [TestMethod]
        public void MessageFireEventTest() {
            MainPageViewModel vm = new MainPageViewModel();
            string message = "Hallo Test";
            bool eventFired = false;
            vm.PropertyChanged += (o, e) => eventFired = e.PropertyName == "Message";
            vm.Message = message;
            Assert.IsTrue(eventFired);
            Assert.AreEqual(message, vm.Message);
        }
    }
}
