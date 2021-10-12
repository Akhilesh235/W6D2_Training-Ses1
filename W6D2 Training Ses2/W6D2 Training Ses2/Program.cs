using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace W6D2_Training_Ses2
{
    class Program
    {
        static void Main(string[] args)
        {
            //file handling examples
            //WriteinFile();
            
            FileStream fs = new FileStream("SampleTest.txt", FileMode.Open, FileAccess.ReadWrite);
            StreamReader sr = new StreamReader(fs);
            Console.WriteLine("Printing content of text file");
            sr.BaseStream.Seek(0, SeekOrigin.Begin);
            string str = sr.ReadLine();
            while(str!=null)
            {
                Console.WriteLine(str);
                str = sr.ReadLine();
            }
            sr.Close();
            fs.Close();
            Console.ReadLine();
        }

        private static void WriteinFile()
        {
            FileStream fs = new FileStream("SampleTest.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite); // opens the file in readwrite format
            StreamWriter streamWriter = new StreamWriter(fs);   //to write in the file, we need the steamwriter

            Console.WriteLine("Enter the text u want to write ");
            var str = Console.ReadLine();

            streamWriter.WriteLine(str);
            streamWriter.Flush();   //waits for writer to finish writing in the file
            streamWriter.Close();   //
            fs.Close();
        }
    }
}
