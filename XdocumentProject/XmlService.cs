using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace XdocumentProject
{
    public class XmlService
    {
        private readonly string xmlFilePath; // Set this to your XML file path

        public XmlService(string xmlFilePath)
        {
            this.xmlFilePath = xmlFilePath;
        }

        public void WriteToXml(string question, string answer)
        {
            // Load existing XML or create a new one if it doesn't exist
            XDocument doc;
            if (File.Exists(xmlFilePath))
            {
                doc = XDocument.Load(xmlFilePath);
            }
            else
            {
                doc = new XDocument(new XElement("Questions"));
            }

            // Add a new question element
            var questionElement = new XElement("Question",
                new XElement("Text", question),
                new XElement("Answer", answer));

            doc.Root?.Add(questionElement);

            // Save changes
            doc.Save(xmlFilePath);
        }

        // Add other methods for reading, updating, and deleting questions as needed
    }
}
