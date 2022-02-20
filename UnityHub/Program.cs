using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnityHub
{

    class ArrayMassiv

    {
        //Дан целочисленный  массив из 20 элементов.Элементы массива 
        // могут принимать  целые значения  от –10 000 до 10 000 
        // включительно.Заполнить случайными числами.

        int[] a;
        Random rnd = new Random();
        public ArrayMassiv(int n, int min, int max)
        {
            a = new int[n];
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = rnd.Next(min, max);
                Console.Write(a[i] + " ");
            }
            Console.WriteLine();
        }

        //Написать программу, позволяющую найти и вывести количество пар элементов
        //массива, в которых только одно число делится на 3. В данной задаче под
        //парой подразумевается два подряд идущих элемента массива.

        public int GetNubers
        {
            get
            {
                int ravno = 0;
                if (a.Length > 1)
                {
                    for (int i = 0; i < a.Length - 1; i++)
                    {
                        if (a[i] % 3 == 0 | a[i + 1] % 3 == 0)
                        {
                            ravno++;
                            Console.WriteLine($"Пара чисел: {a[i]}, {a[i + 1]}");
                        }
                    }
                }
                return ravno;
            }
        }
    }
    //2. Реализуйте задачу 1 в виде статического класса StaticClass;
    //а) Класс должен содержать статический метод, который принимает на вход массив и решает задачу 1;
    //б) Добавьте статический метод для считывания массива из текстового файла.Метод должен возвращать массив целых чисел;
    //в)* Добавьте обработку ситуации отсутствия файла на диске.
    class Program
    {
        static void Task()
        {
            int[] myFileArray = ArrayClass.LoadToArray("medet.txt");
            int i = ArrayClass.GetNumberGroups(myFileArray);
        }
        static void Main(string[] args)
        {
            ArrayMassiv a = new ArrayMassiv(5, 1, 10);
            Console.WriteLine("Результат" + a.GetNubers);

            Task();
        }
    }

}
