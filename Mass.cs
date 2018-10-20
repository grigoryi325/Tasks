using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Treaning_CS
{
    class Program
    {
        static void Main()
        {
            //ініціалізуємо масив чисел
            int[] num = { 300, 250, 250, 500, 500, 200, 200, 200, 200, 150 };

            //ініціалізуємо змінні
            int previus_item = 0;
            int count = 0;
            int s, f = 0;

            Console.WriteLine("Входящий масив:");
            for (int i = 0; i < num.Length; i++)
            {
                Console.Write(num[i]+" ");
            }

            Console.WriteLine("\n");

            //за допомогою циклу for перебираємо масив
            for (int i = 0; i < num.Length; i++)
            {
                //зберігаємо початкову позицію числа
                s = i + 1;

                //якщо поточне число не рівне попередньому то пробігаємось по масиву і 
                //підраховуємо кількість цього числа в масиві
                if (num[i] != previus_item)
                {

                    for (int j = 0; j < num.Length; j++)
                    {

                        if (num[i] == num[j])
                        {
                            count++;
                        }
                    }
                    //зберігаємо кінцеву позицію числа
                    f = count + s - 1;
                }

                //виводемо результат 
                if (count != 0)
                {
                    if (count == 1)
                    {
                        Console.WriteLine("a" + s + "=" + num[i]);
                    }
                    else
                    {
                        Console.WriteLine("a" + s + "-" + "a" + f + "=" + num[i]);
                    }
                }

                //обнуляємо значення змінних
                count = 0;
                s = 0;
                f = 0;

                //присвоюєм значення, яке буде виступати попереднім числом
                previus_item = num[i];
            }

            //затримка, програма завершиться після натиснення будь-якої клавіші
            Console.ReadKey();

        }
    }  
}