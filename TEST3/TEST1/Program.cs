using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;
using TEST1.Tests;

namespace TEST1
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = args[0];
            int count = Convert.ToInt32(args[1]);
            string filename = args[2];
            string format = args[3];
            if (type == "RepositoryDescription")
            {
                GenerateForDescription(count, filename, format);
            }
            else if (type == "Repository")
            {
                GenerateForRep(count, filename, format);
            }
            else
            {
                Console.Out.Write("Unrecognized type of data" + type);
            }
        }

        static void GenerateForDescription(int count, string filename, string format)
        {
            List<RepositoryDescription> desc = new List<RepositoryDescription>();
            for (int i = 0; i < count; i++)
            {
                desc.Add(new RepositoryDescription(GeneratorString.Generate(), GeneratorString.Generate()));
            }

            StreamWriter writer = new StreamWriter(filename);
            if (format == "csv")
            {
                WriteDescriptionToCsvFile(desc, writer);
            }
            else if (format == "xml")
            {
                WriteDescriptionToXmlFile(desc, writer);
            }
            else
            {
                Console.Out.Write("Unrecognized format" + format);
            }
            writer.Close();
        }

        static void GenerateForRep(int count, string filename, string format)
        {
            List<Repository> tw = new List<Repository>();
            for (int i = 0; i < count; i++)
            {
                tw.Add(new Repository(GeneratorString.Generate(), GeneratorString.Generate()));
            }
            StreamWriter writer = new StreamWriter(filename);
            if (format == "csv")
            {
                WriteRepToCsvFile(tw, writer);
            }
            else if (format == "xml")
            {
                WriteRepToFile(tw, writer);
            }
            else
            {
                Console.Out.Write("Unrecognized format" + format);
            }
            writer.Close();
        }

        static void WriteDescriptionToCsvFile(List<RepositoryDescription> desc, StreamWriter writer)
        {
            foreach (RepositoryDescription data in desc)
                writer.WriteLine(string.Format("${0}",
                    data.Footer));
        }

        static void WriteRepToCsvFile(List<Repository> text, StreamWriter writer)
        {
            foreach (Repository data in text)
            {
                writer.WriteLine(string.Format("${0} {1}",
                    data.Header, data.Footer));
            }

        }

        private static void WriteDescriptionToXmlFile(List<RepositoryDescription> desc, StreamWriter writer)
        {
            new XmlSerializer(typeof(List<RepositoryDescription>)).Serialize(writer, desc);
        }

        private static void WriteRepToFile(List<Repository> text, StreamWriter writer)
        {
            new XmlSerializer(typeof(List<Repository>)).Serialize(writer, text);
        }
    }
}
