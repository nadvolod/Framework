using System;
using Framework;
using Framework.Pages;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
    [TestClass]
    public class AutomationTestingPageOpens : TestBase
    {
        [TestMethod]
        public void RunTest()
        {
            Pages.AutomationTestingPractice.Goto();
            Assert.IsTrue(Pages.AutomationTestingPractice.IsAt());
        }
    }
}
