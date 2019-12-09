using NUnit.Framework;

namespace TEST1.Tests
{
    [TestFixture]
    public class ChangeRepository : AuthBase
    {
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
    }
}
