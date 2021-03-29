using System;
using System.IO;
using System.Text;

namespace Lesson3
{
    class Program
    {
        static void Main(string[] args)
        {
           // Создание файла - StreamWriter (поток) с передаваемыми парамметрами
           // В качестве парамметра передаём имя файла или полный путь с именем.
           using(var sw = new StreamWriter("file.txt", true, Encoding.UTF8)) 
           {
                sw.Write("Write string to file...");
                sw.WriteLine("String from new line...");
           }

            using (var sr = new StreamReader("file.txt", Encoding.UTF8))
            {
                // Построчное чтение файла
                while(!sr.EndOfStream)
                {
                    Console.Write(sr.ReadLine());
                }

                // Перевод позиции на начало файла после прочтения по строке
                sr.DiscardBufferedData();
                sr.BaseStream.Seek(0, SeekOrigin.Begin);


                // Чтения файла целиком
                var textFromFile = sr.ReadToEnd();
                Console.Write(textFromFile);

                Console.ReadLine();
            }
        }
    }
}
