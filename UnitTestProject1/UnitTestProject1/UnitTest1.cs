using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
        }
        [TestMethod]

        public void NullTest()
        {
            string uName = null;
            string uPwd = null;
            string result = "Provide username and password";
            Assert.AreEqual(result, SingInManager.SignIn(uName, uPwd));
        }
    }
}
