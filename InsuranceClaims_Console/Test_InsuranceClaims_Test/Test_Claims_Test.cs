using System;
using InsuranceClaims_Repository;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace Test_InsuranceClaims_Test
{
    [TestClass]
    public class Test_Claims_Test
    {
        [TestMethod]
        public void Method()
        {
            Claims_Repository _claimsContentQueue = new Claims_Repository();
            Assert.AreEqual(1, _claimsContentQueue.GetClaimsContentQueue().Count);

        }

        [TestMethod]
        public void AddMethod()
        {

        }

        [TestMethod]
        public void MyTestMethod()
        {

        }
    }
}
