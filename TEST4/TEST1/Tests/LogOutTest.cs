using NUnit.Framework;

namespace TEST1.Tests
{
    class LogOutTest: AuthBase
    {
        [Test]
        public void Logout()
        {
            SetupLogin();

            Assert.IsTrue(app.auth.Test_Logout(), "Logout exception");
        }
    }
}
