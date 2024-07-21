
using System;
using System.IO;
using System.Xml.Linq;

namespace XdocumentProject
{



    class Program
    {
        static void Main()
        {
            var xmlService = new XmlService("");

            // Example usage:
            //xmlService.WriteToXml("What is the capital of France?", "Paris");
            Console.WriteLine("to enter a qwest press 1 \n for answering press 2");
            string ans = Console.ReadLine();
            if (ans == "1")
            {
                Console.WriteLine("enter your question");
                string newQwest = Console.ReadLine()!;
                Console.WriteLine("enter the corecct answer");
                string newAnswer = Console.ReadLine()!;
                //xmlService.WriteToXml($"{newQwest}", $"{newAnswer}");
                //var questionElement = new XElement("Question",
                //new XElement("question", newQwest),
                //new XElement("Answer", newAnswer));
                xmlService.WriteToXml(newQwest,newAnswer);
            }
            
        }
    }
}