using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace UnityHub
{
    class ArrayClass
    {
        static public int GetNumberGroups(int[] exemple)
        {
            int number = 0;
            if (exemple.Length > 1)
            {
                for (int i = 0; i < exemple.Length - 1; i++)
                {
                    if (exemple[i] % 3 == 0 ^ exemple[i + 1] % 3 == 0)
                        number++;
                }
            }
            return number;
        }
        static public int[] LoadToArray(string fileName)
        {
            int[] exampleArray;
            StreamReader s;
            int i = 0;
            if (File.Exists(fileName))
            {
                exampleArray = new int[File.ReadAllLines(fileName).Length];
                s = new StreamReader(fileName);
                while (!s.EndOfStream)
                {
                    if (!int.TryParse(s.ReadLine(), out exampleArray[i]))
                    {
                        Console.WriteLine($"На {i + 1} строке не число. Строка пропущена.");
                    }
                }
            }
            else
            {
                Console.Write($"Файл не найден {fileName}");
                throw new FileNotFoundException();
            }
            s.Close();
            return exampleArray;
        }
    }
}
