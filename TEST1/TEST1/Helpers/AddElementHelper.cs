using OpenQA.Selenium;
using System;

namespace TEST1.Helpers
{
    public class AddElementHelper : HelperBase
    {
        public AddElementHelper(ApplicationManager manager) : base(manager)
        {
        }

        public void Test_AddElement()
        {
            driver.FindElement(By.LinkText("New")).Click();
            driver.FindElement(By.Id("repository_name")).Click();
            driver.FindElement(By.Id("repository_name")).Clear();
            driver.FindElement(By.Id("repository_name")).SendKeys(Guid.NewGuid().ToString().ToUpper());
            driver.FindElement(By.Id("repository_description")).Click();
            driver.FindElement(By.Id("repository_description")).Clear();
            driver.FindElement(By.Id("repository_description")).SendKeys("blabla");
            driver.FindElement(By.Id("repository_visibility_private")).Click();
        }
    }
}
