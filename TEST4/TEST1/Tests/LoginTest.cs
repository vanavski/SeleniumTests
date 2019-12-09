using NUnit.Framework;

namespace TEST1.Tests
{
    [TestFixture]
    class LoginTest : AuthBase
    {
        [Test]
        public void Login()
        {

            Assert.IsTrue(app.auth.Test_LogIn(account), "Login exception");
            app.auth.Test_Logout();
        }

        [Test]
        public void WrongLogin()
        {
            Assert.IsTrue(app.auth.Test_LogIn(new AccountData(account.Username + "1", account.Password)), "Login exception");
            app.auth.Test_Logout();
        }

        [Test]
        public void AddElement()
        {
            SetupLogin();
            Assert.IsTrue(app.element.Test_AddElement(), "Add element exception");
            app.auth.Test_Logout();
        }

        [Test]
        public void EditElement()
        {
            try
            {
                SetupLogin();
                app.element.Test_AddElement();
                Assert.IsTrue(app.element.Test_EditElement(), "Edit element exception");
                app.auth.Test_Logout();
            }
            catch
            {
                app.auth.Test_Logout();
            }
        }

        [Test]
        public void Logout()
        {
            SetupLogin();

            Assert.IsTrue(app.auth.Test_Logout(), "Logout exception");
        }
    }
}
