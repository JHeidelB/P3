using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
/*
 * JAMAE: 
 * WORKED WITH TRAVIS ON THIS POTION OF THE PROBLEM, HE COMMITTED BACK 
 * TO THE GETHUB REPO THAT HE WAS RUNNING INTO ERROR WHEN TRYING TO 
 * ADD THE REFERANCE, THIS IS HIS PORTION OF THE CODE, NO MATTER WHAT WE 
 * DID WE COULD NOT GET THE "using CSC470-P3" TO SHOW UP, WHEN MANUALY 
 * TYPING IN THIS SECTION HE FLAGGED WITH ERRORS. 
 */
namespace UnitTestAppUserFakeRepository
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestLoginAuthenticationPass()
        {
            // Arrange
            string UserName = "JamaeNicole";
            string Password = "Reynolds1991";
            FakeAppUserRepository EmpRepository = FakeAppUserRepository();

            // Act
            bool Check = Login(UserName, Password);

            // Assert
            Assert.AreEqual(true, Check);

        }
        public void TestLoginAuthenticationFail()
        {
            // Arrange
            string UserName = "TravisAlan";
            string Password = "NotThePassword";
            FakeAppUserRepository EmpRepository = FakeAppUserRepository();

            // Act
            bool Check = Login(UserName, Password);

            // Assert
            Assert.AreNotEqual(true, Check);

        }
    }
}
