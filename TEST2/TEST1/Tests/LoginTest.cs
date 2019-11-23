using NUnit.Framework;

namespace TEST1.Tests
{
    [TestFixture]
    class LoginTest : TestBase
    {
        public AccountData LoginData()
        {
            app.Navigation.GoToHomePage();
            return new AccountData("pwommm@mail.ru", "Dflbv123@");
        }

        [Test]
        public void Login()
        {
            var user = LoginData();

            Assert.IsTrue(app.auth.Test_LogIn(user), "Login exception");
            app.auth.Test_Logout();
        }

        [Test]
        public void AddElement()
        {
            var user = LoginData();
            app.auth.Test_LogIn(user);
            Assert.IsTrue(app.element.Test_AddElement(), "Add element exception");
            app.auth.Test_Logout();
        }

        [Test]
        public void EditElement()
        {
            try
            {
                var user = LoginData();
                app.auth.Test_LogIn(user);
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
            var user = LoginData();
            app.auth.Test_LogIn(user);

            Assert.IsTrue(app.auth.Test_Logout(), "Logout exception");
        }
    }
}
