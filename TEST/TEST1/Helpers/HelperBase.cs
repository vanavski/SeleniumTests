using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace TEST1.Helpers
{
    public class HelperBase
    {
        protected ApplicationManager manager;
        protected IWebDriver driver;
        public HelperBase(ApplicationManager manager)
        {
            this.manager = manager;
            driver = manager.Driver;
        }
    }
}
