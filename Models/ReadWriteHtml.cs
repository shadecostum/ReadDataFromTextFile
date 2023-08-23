using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace ReadDataFromTextFile.Models
{
    internal class ReadWriteHtml
    {
     public   ReadWriteHtml() {

            string htmlFilePath = @"C:\TextFolder\htmlFile.html";

            using (StreamReader reader = new StreamReader(htmlFilePath))
            {
                string htmlContent = reader.ReadToEnd();
                Console.WriteLine("HTML Content:");
                Console.WriteLine(htmlContent);

            }

            string htmlWirtePath = @"C:\TextFolder\htmlWrite.html";
            using (StreamWriter htmlWrite = new StreamWriter(htmlWirtePath))
            {
                htmlWrite.WriteLine("<h1>akash written on html</h1>");
                htmlWrite.WriteLine("<h2>second sentence written on html</h2>");
            }
            Console.WriteLine("html have written");
        }
       

    }
}
