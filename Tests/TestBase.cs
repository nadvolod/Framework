using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Framework
{
    public class TestBase
    {
        [TestInitialize]
        public static void Initialize()
        {
            Browser.Initialize();
        }

        public static void TestFixtureTearDown()
        {
            Browser.Close();
        }

        [TestCleanup]
        public static void TearDown()
        {
            Browser.Close();
        }
    }
}
