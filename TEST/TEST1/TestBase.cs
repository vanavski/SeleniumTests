using NUnit.Framework;
using TEST1.Helpers;

namespace TEST1
{
    [TestFixture]
    public class TestBase
    {
        protected ApplicationManager app;

        [SetUp]
        public void SetupTest()
        {
            app = new ApplicationManager();
        }

        [TearDown]
        public void TeardownTest()
        {
            app.Stop();
        }        
    }
}
