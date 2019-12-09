using NUnit.Framework;

namespace TEST1.Tests
{
    [TestFixture]
    class LoginTest : TestBase
    {
        [Test]
        public void Login()
        {
            Assert.IsTrue(app.auth.Test_LogIn(new AccountData(Settings.Login, Settings.Password)), "Login exception");
            app.auth.Test_Logout();
        }

        [Test]
        public void WrongLogin()
        {
            Assert.IsFalse(app.auth.Test_LogIn(new AccountData(Settings.Login + "1", Settings.Password)), "Login exception");
            app.auth.Test_Logout();
        }
    }
}
