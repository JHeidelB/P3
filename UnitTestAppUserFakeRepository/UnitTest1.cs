using Microsoft.VisualStudio.TestTools.UnitTesting;

/*
 * TRAVIS: 
 * STILL UNABLE TO ADD THE REFERANCE, I HAVE ADDED TO THE 
 * UNIT TEST REFERANCE AS STATED IN YOUR EMAIL. BUT IT WONT
 * ALLOW US TO ADD IT TO THE REFERANCE AT THE TOP OF THE .cs 
 * DOCUMENT
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
            FakeAppUserRepository EmpRepository = new FakeAppUserRepository();

            // Act
            bool Check = EmpRepository.Login(UserName, Password);

            // Assert
            Assert.AreEqual(true, Check);

        }
        public void TestLoginAuthenticationFail()
        {
            // Arrange
            string UserName = "TravisAlan";
            string Password = "NotThePassword";
            FakeAppUserRepository EmpRepository = new FakeAppUserRepository();

            // Act
            bool Check = EmpReposity.Login(UserName, Password);

            // Assert
            Assert.AreNotEqual(true, Check);

        }
    }
}
