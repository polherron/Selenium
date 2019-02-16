using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestFramework;

namespace Tests
{
    [TestFixture]
    public class TestClass1
    {
        [Test]
        public void TestTestPhoneNumberMethod()
        {

            Pages.AboutUs.GoTo();
            bool result = Pages.AboutUs.checkPhoneNumber();
            Assert.IsTrue(result);
        }

    //    [Test]
    //    public void IsAtAboiutPage()
    //    {

    //        Pages.AboutUs.GoTo();
    //        Pages.AboutUs.IsAt();
    //        Assert.IsTrue(Pages.AboutUs.IsAt());
    //    }
    }
}
