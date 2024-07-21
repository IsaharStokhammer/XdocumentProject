
using System;
using System.IO;
using System.Xml.Linq;

namespace XdocumentProject
{



    class Program
    {
        static void Main()
        {
            var xmlService = new XmlService(@"C:\Users\user1\source\repos\XdocumentProject\XdocumentProject\XMLFile1.xml");

            // Example usage:
            xmlService.WriteToXml("What is the capital of France?", "Paris");
        }
    }
}