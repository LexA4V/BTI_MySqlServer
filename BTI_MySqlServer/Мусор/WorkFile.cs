using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace BTI_MySqlServer
{
    class WorkFile
    {
        public static void WriteToFile(string[] stringArray, string pathFile)
        {
            try
            {
                // создаем объект BinaryWriter
                using (BinaryWriter binaryWriter = new BinaryWriter(File.Open(pathFile, FileMode.Create)))
                {
                    // записываем в файл значение каждого поля структуры
                    foreach (string arrayElement in stringArray)
                        binaryWriter.Write(arrayElement);
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public static void ReadInFile(string pathFile)
        {
            // создаем объект BinaryReader
            try
            {
                using (BinaryReader reader = new BinaryReader(File.Open(pathFile, FileMode.Open)))
                {
                    // пока не достигнут конец файла
                    // считываем каждое значение из файла
                    while (reader.PeekChar() > -1)
                    {
                        string name = reader.ReadString();
                        string capital = reader.ReadString();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}