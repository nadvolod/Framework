using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework
{
    public class TestBase
    {
        []
        public static void Initialize()
        {
            Browser.Initialize();
        }

        [TearDown]
        public static void TestFixtureTearDown()
        {
            Browser.Close();
        }

        [TearDown]
        public static void TearDown()
        {
        }
    }
}
