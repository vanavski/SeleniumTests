using NUnit.Framework;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace TEST1.Tests
{
    [TestFixture]
    public class XMLCreationRepository: TestBase
    {
        public static IEnumerable<RepositoryDescription> RepositoryDescriptionFromXmlFile()
        {
            return (List<RepositoryDescription>)new XmlSerializer(typeof(List<RepositoryDescription))
                .Deserialize(new StreamReader(@"DescriptionRepository.xml"));
        }

        public static IEnumerable<Repository> RepositoryFromXmlFile()
        {
            return (List<RepositoryDescription>)new XmlSerializer(typeof(List<RepositoryDescription))
                .Deserialize(new StreamReader(@"Repository.xml"));
        }

        [Test, TestCaseSource("RepositoryDescriptionFromXmlFile")]
        public void EditRepository()
        {
            var test = new LoginTest();
            test.EditElement();
        }

        [Test, TestCaseSource("RepositoryFromXmlFile")]
        public void AddRepository()
        {
            var test = new LoginTest();
            test.AddElement();
        }
    }
}
