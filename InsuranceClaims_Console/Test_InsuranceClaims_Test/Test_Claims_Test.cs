using System;
using InsuranceClaims_Repository;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace Test_InsuranceClaims_Test
{
    [TestClass]
    public class Test_Claims_Test
    {
        [TestMethod]
        public void NewClaim()
        {
            Claims_Repository _claimsContentQueue = new Claims_Repository();

            Claims_Content content = new Claims_Content();
            content.Description = "hi";
            string expected = "hi";


            Assert.AreEqual(expected , content.Description);

        }

    }
}
