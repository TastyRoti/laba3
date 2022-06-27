using System;
using System.IO;
using System.Collections.Generic;

namespace Lab_3
{
    class EX1
    {
        static void Main(string[] args)
        {
            try
            {
                StreamReader File = new StreamReader("read.txt");
                List<string> list = new List<string> { };
                while (!File.EndOfStream)
                {
                    list.Add(File.ReadLine());
                }
                File.Close();

                list.Reverse();
                StreamWriter File2 = new StreamWriter("write.txt");
                for (int i = 0; i < list.Count; i++)
                {
                    File2.WriteLine(list[i]);
                }
                File2.Close();
                Console.WriteLine("Успішно");
            }
            catch { Console.WriteLine("Помилка"); }
        }
    }
}
