using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadDataFromTextFile.Models
{
    internal class ReadWriteFile
    {
        public ReadWriteFile() 
        {

            string fileName = @"C:\TextFolder\FileOne.txt";
            StreamReader streamReaderFiler = new StreamReader(fileName);
            string fileContent = streamReaderFiler.ReadToEnd();
            Console.WriteLine(fileContent);


            string filePath = @"C:\TextFolder\output.txt";
            StreamWriter writer = new StreamWriter(filePath);
            string sentence = "Hello, this is a sentence written to a text file.\n second line";
            writer.WriteLine(sentence);
            Console.WriteLine("Sentence written to the text file.");

        }
    }
}
