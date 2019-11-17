using OpenQA.Selenium;

namespace TEST1.Helpers
{
    public class LoginHelper : HelperBase
    {
        public LoginHelper(ApplicationManager manager) : base(manager)
        {
        }

        public void Test_LogIn(AccountData account)
        {
            driver.FindElement(By.LinkText("Sign in")).Click();
            driver.FindElement(By.Id("login_field")).Click();
            driver.FindElement(By.Id("login_field")).Clear();
            driver.FindElement(By.Id("login_field")).SendKeys(account.Username);
            driver.FindElement(By.Id("password")).Click();
            driver.FindElement(By.Id("password")).Clear();
            driver.FindElement(By.Id("password")).SendKeys(account.Password);
            driver.FindElement(By.Name("commit")).Click();
        }

        public void Test_Logout()
        {
            driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='New project'])[1]/following::span[2]")).Click();
            driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Settings'])[1]/following::button[1]")).Click();
        }
    }
}
