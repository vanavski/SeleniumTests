using NUnit.Framework;

namespace TEST1
{
    public class AuthBase : TestBase
    {
        protected AccountData account = new AccountData(Settings.Login, Settings.Password);

        [SetUp]
        public bool SetupLogin()
        {
            if (app.auth.IsLoggedIn(false))
            {
                if (app.auth.Test_LogIn(account))
                {
                    app.auth.SetLoggedIn(true);
                    return true;
                }
            }
            return false;
        }
    }
}
