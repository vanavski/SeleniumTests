using NUnit.Framework;

namespace TEST1.Tests
{
    [TestFixture]
    class LoginTest : TestBase
    {
        [Test]
        public void Login()
        {
            app.Navigation.GoToHomePage();
            var user = new AccountData("pwommm@mail.ru", "Dflbv123@");
            app.auth.Test_LogIn(user);
        }

        [Test]
        public void AddElement()
        {
            Login();
            app.Navigation.GoToHomePage();
            app.element.Test_AddElement();
        }

        [Test]
        public void Logout()
        {
            Login();
            app.Navigation.GoToHomePage();
            app.auth.Test_Logout();
        }
    }
}
