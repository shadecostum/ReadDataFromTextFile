using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadDataFromTextFile.Models
{
    internal class ReadWriteApp
    {
        public ReadWriteApp() 
        {
            Console.WriteLine("Enter your userName");
            string readUserName= Console.ReadLine(); 
            string writePath= @"C:\TextFolder\WriteUserNameApp.txt";
            using(StreamWriter fileWriting= new StreamWriter(writePath,true)) 
            {
                fileWriting.WriteLine(readUserName);
            }
            Console.WriteLine("userName writed");
        }
    }
}
