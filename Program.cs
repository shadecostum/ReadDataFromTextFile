using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;//Encoding utf8 from heer
using System.Threading.Tasks;
using System.IO;
using ReadDataFromTextFile.Models;

namespace ReadDataFromTextFile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("========================= HTML File Read Write================================");
            ReadWriteHtml readWriteHtml=new ReadWriteHtml();
           
            Console.WriteLine("========================= XML  File Read Write================================");
           
            ReadWriteXml readWriteXml=new ReadWriteXml();
            Console.WriteLine(" ========================= Text File Read Write===============================");
         
            ReadWriteFile readWriteFile=new ReadWriteFile();
            Console.WriteLine("===========================USER NAME WRITING APP==============================");

            ReadWriteApp readWriteApp=new ReadWriteApp();
           /* Console.WriteLine("==============================================================================");
            string newFile = @"C:\Users\acer\Desktop\AurionTraining\dasdad.txt";
            var newDate = File.ReadAllText(@newFile);
            Console.WriteLine(newDate);
            Console.WriteLine("==============================================================================");*/

        }
    }
}
