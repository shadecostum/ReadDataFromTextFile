using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadDataFromTextFile.Models
{
    internal class ReadWriteXml
    {
        public ReadWriteXml() 
        {
            string xmlPath = @"C:/TextFolder/XmlFile.xml";
            StreamReader xmlReader = new StreamReader(xmlPath);
            string xmlRead = xmlReader.ReadToEnd();
            Console.WriteLine(xmlRead);

            string xmlWritePath = @"C:\TextFolder\XmlWrite.xml";
            using (StreamWriter xmlWriter = new StreamWriter(xmlWritePath))
            {
                xmlWriter.WriteLine("<sentence> XML file akash has written </sentence>");
            }
            Console.WriteLine("XML content written to file.");
          


        }
    }
}
