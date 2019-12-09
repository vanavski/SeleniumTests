using System;
using System.Xml;

namespace TEST1
{
    public static class Settings
    {
        public static string file = "Settings.xml";

        #region Fields
        private static string baseUrl;
        private static string login;
        private static string password;
        private static string userName;
        private static XmlDocument document;
        #endregion

        static Settings()
        {
            if (!System.IO.File.Exists(file)) { throw new Exception("Problem: settings file not found: " + file); }
            document = new XmlDocument();
            document.Load(file);
        }

        #region Properties
        public static string BaseUrl
        {
            get
            {
                if (baseUrl == null)
                {
                    XmlNode node = document.DocumentElement.SelectSingleNode("BaseUrl");
                    baseUrl = node.InnerText;
                }
                return baseUrl;
            }
        }

        public static string Login
        {
            get
            {
                if (login == null)
                {
                    XmlNode node = document.DocumentElement.SelectSingleNode("Login");
                    login = node.InnerText;
                }
                return login;
            }
        }

        public static string Password
        {
            get
            {
                if (password == null)
                {
                    XmlNode node = document.DocumentElement.SelectSingleNode("Password");
                    password = node.InnerText;
                }
                return password;
            }
        }
        #endregion
    }
}
