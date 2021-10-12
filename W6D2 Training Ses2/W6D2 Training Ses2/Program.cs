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
            WriteinFile();

            ReadfromFile();
        }

        private static void ReadfromFile()
        {
            FileStream fs = new FileStream("SampleTest.txt", FileMode.Open, FileAccess.ReadWrite);
            StreamReader sr = new StreamReader(fs);
            Console.WriteLine("Printing content of text file");
            sr.BaseStream.Seek(0, SeekOrigin.Begin);
            string str = sr.ReadToEnd();
            Console.WriteLine(str);
            //while(str!=null)
            //{
            //    Console.WriteLine(str);
            //    str = sr.ReadLine();
            //}
            sr.Close();
            fs.Close();
            Console.ReadLine();
        }

        private static void WriteinFile()
        {
            FileStream fs = new FileStream("SampleTest.txt", FileMode.Create, FileAccess.ReadWrite); // this is to overwrite the file... just use the same filename
            //FileStream fs = new FileStream("SampleTest.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite); // opens the file in readwrite format
            StreamWriter streamWriter = new StreamWriter(fs);   //to write in the file, we need the steamwriter

            Console.WriteLine("Enter the text1 u want to write ");
            var str1 = Console.ReadLine();

            Console.WriteLine("Enter the text2 u want to write ");
            var str2 = Console.ReadLine();

            streamWriter.WriteLine(str1);
            streamWriter.WriteLine(str2);
            streamWriter.Flush();   //waits for writer to finish writing in the file --> it will push all the bytes before u close
            streamWriter.Close();   //
            fs.Close();
        }
    }
}
