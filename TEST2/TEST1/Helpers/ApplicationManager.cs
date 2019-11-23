using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Text;
using System.Threading;

namespace TEST1.Helpers
{
    public class ApplicationManager
    {
        private IWebDriver driver;
        private StringBuilder verificationErrors;
        private string baseURL;
        public NavigationHelper navigation;
        public LoginHelper auth;
        public AddElementHelper element;

        private static ThreadLocal<ApplicationManager> app = new ThreadLocal<ApplicationManager>();

        public static ApplicationManager GetInstance()
        {
            if (!app.IsValueCreated)
            {
                ApplicationManager newInstance = new ApplicationManager();
                newInstance.Navigation.GoToHomePage();
                app.Value = newInstance;
            }
            return app.Value;
        }

        public ApplicationManager()
        {
            driver = new ChromeDriver(@"D:\distr");
            driver.Manage().Window.Maximize();
            baseURL = "https://github.com";
            verificationErrors = new StringBuilder();
            auth = new LoginHelper(this);
            navigation = new NavigationHelper(this, baseURL);
            element = new AddElementHelper(this);
        }

        ~ApplicationManager()
        {
            try
            {
                driver.Quit();
            }
            catch (Exception)
            {
                //ignore
            }
        }

        public IWebDriver Driver { get { return driver; } }
        public NavigationHelper Navigation { get { return navigation; } }

        public void Stop()
        {
            try
            {
                driver.Quit();
            }
            catch (Exception)
            {
                //Ignore errors if unable to close the browser
            }
            Assert.AreEqual("", verificationErrors.ToString());
        }
    }
}
