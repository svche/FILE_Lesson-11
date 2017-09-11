using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FILE_Lesson_11
{
    class Program
    {
        static void Main(string[] args)
        {
            //StreamWriter sw = new StreamWriter("1.txt");
            //sw.WriteLine("new line every time");
            //sw.Close();

            //    StreamReader sr = new StreamReader("1.txt");
            //    string line;
            //    while ((line = sr.ReadLine()) != null)
            //    {
            //        Console.WriteLine(line);
            //        Console.WriteLine("********************");

            //        string[] array = line.Split();
            //        foreach (string str in array) Console.WriteLine(str);
            //    }
            //    sr.Close();


            //string fileName = "my file.txt";
            //Console.Write("Write text: ");
            //string text = Console.ReadLine();

            //Writening(fileName, text);

            //Console.Write("From file: ");
            //string s = Reading(fileName);
            //Console.WriteLine(s);


            string fileName = "my file.txt";
            string[] result = ReadArray(fileName);
            foreach (string r in result) Console.WriteLine(r);


        }

        static string[] ReadArray(string fileName)
        {
            string[] result;

            StreamReader sr = new StreamReader(fileName);

            int counter = 0;

            string line;

            while(sr.ReadLine() != null)
            {
                counter++;
            }
            sr.Close();

            StreamReader srNew = new StreamReader(fileName);
            result = new string[counter];

            counter = 0;

            while ((line = srNew.ReadLine()) != null)
            {
                result[counter] = line;
                counter++;
            }
            srNew.Close();

            
            return result;//instead of result & all body of method - File.ReadAllLines();


        }

        static void Writening(string fileName, string text)
        {
            StreamWriter sw = new StreamWriter(fileName);
            sw.WriteLine(text);
            sw.Close();
        }

        static string Reading(string fileName)
        {
            StreamReader sr = new StreamReader(fileName);
            string line = sr.ReadLine();
            sr.Close();
            return line;
        }
    }
}
