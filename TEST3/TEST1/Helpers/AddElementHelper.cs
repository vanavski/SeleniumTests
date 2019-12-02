using OpenQA.Selenium;
using System;

namespace TEST1.Helpers
{
    public class AddElementHelper : HelperBase
    {
        public AddElementHelper(ApplicationManager manager) : base(manager)
        {
        }

        public bool Test_AddElement()
        {
            try
            {
                driver.FindElement(By.LinkText("New")).Click();
                driver.FindElement(By.Id("repository_name")).Click();
                driver.FindElement(By.Id("repository_name")).Clear();
                driver.FindElement(By.Id("repository_name")).SendKeys(Guid.NewGuid().ToString().ToUpper());
                driver.FindElement(By.Id("repository_description")).Click();
                driver.FindElement(By.Id("repository_description")).Clear();
                driver.FindElement(By.Id("repository_description")).SendKeys("bbbbbbb");
                driver.FindElement(By.Id("repository_visibility_private")).Click();
                driver.FindElement(By.Id("repository_auto_init")).Click();
                driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Nothing to show'])[2]/following::button[1]")).Click();

                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool Test_EditElement()
        {
            try
            {
                driver.Navigate().GoToUrl("https://github.com/IvanaevskiyVadim709/bbbbbbbbbbb");
                driver.FindElement(By.CssSelector("svg.octicon.octicon-pencil > path")).Click();
                driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='bbbbbbb'])[1]/following::pre[1]")).Click();
                driver.FindElement(By.Name("value")).Clear();
                driver.FindElement(By.Name("value")).SendKeys("# bbbbbbbbbbb\nbbbbbbb\n" + Guid.NewGuid().ToString().ToUpper());
                driver.FindElement(By.Id("submit-file")).Click();
                return false;
            }
            catch
            {
                return true;
            }
        }
    }
}
