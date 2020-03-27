using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3 //Дана строка, вывести только те слова, которые встречаются в ней только один раз
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку");
            string str = Console.ReadLine();
            string[] myArray = str.Split(' ', '.', ',', '!', '?', ';');//Без Split не смог
            //char[] myArray = str.ToArray<char>();
            checkArray(myArray);
            Console.ReadLine();
        }
        //Функция определения слова повторяемого один раз
        private static void checkArray(string[] myArray)
        {
            for (int i = 0; i < myArray.Length; i++)
            {
                int counter = 0;
                string temp = myArray[i];
                for (int j = 0; j < myArray.Length; j++)
                {
                    if (myArray[j]==temp)
                    {
                        counter++;
                    }
                }
                if (counter == 1)
                {
                    Console.WriteLine(temp);
                }
            }
        }
        //Вывод массива для проверки
        private static void outputArray(string[] myArray)
        {
            for (int i = 0; i < myArray.Length; i++)
            {
                Console.Write(myArray[i]+" ");
            }
        }
    }
}
