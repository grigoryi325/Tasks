using System;

namespace Treaning_CS
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Входная строка:");
            //ввод строки из клавиатуры
            string r = Console.ReadLine();
            //с помощью функции Split розбиваем строку на подстроки слов 
            //результатом будет масив слов
            string[] array_words = r.Split(' ');
            //перебираем масив слов
            for (int i = 0; i < array_words.Length; i++)
            {
                //с помощью функции EndsWith узнаем каким символом заканчивается слово
                //если оно заканчиваеться на "a"
                if (array_words[i].EndsWith("a") == true)
                {
                    //то инициализируем строковую переменную z
                    string z = "";
                    //если длина слова не равняется длине переменной z
                    while (array_words[i].Length != z.Length)
                    {
                        //то добавляем в переменную z символ "*"
                        //иными словами формируэм строку из звездочек которая будет равна по длине слову которое нужно подчеркунуть
                        z += "*";
                    }
                    //по сути меняем слово на звездочки
                    array_words[i] = z;
                }
                else
                {
                    //остальные слова заменяем пробалами
                    string z = "";
                    while (array_words[i].Length != z.Length)
                    {
                        z += " ";
                    }
                    array_words[i] = z;
                }
            }

            Console.WriteLine();
            Console.WriteLine("Результат: ");
            Console.WriteLine(r);
            //выводим сформированный ранее масив звездочек для слов которые нужно подчеркнуть и пробелы 
            for (int i = 0; i < array_words.Length; i++)
            {
                Console.Write(array_words[i] + " ");
            }
            Console.ReadKey();
        }

    }
}