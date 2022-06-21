using System;
using System.Collections.Generic;
using System.Linq;

namespace Лаба_1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {
                Console.Clear();
                try
                {
                    Console.WriteLine("Выбор задания 1/2/3");

                    string pick = Console.ReadLine();
                    if (pick == "1")
                    {
                        Zadanie1();
                    }
                    if (pick == "2")
                    {
                        Zadanie2(); 
                    }
                    if (pick == "3")
                    {
                        Zadanie3();
                    }
                }
                catch
                {
                    Console.WriteLine("Ошибка ввода");
                    Console.ReadKey();
                    Console.Clear();
                    continue;
                }
            }
        }
        static void Zadanie1() 
        {
            Console.Clear();
            Console.WriteLine("Введите текст");
            string a;
            a = Console.ReadLine();
            string[] mystring = a.Split(' ');
            var ex1 = new List<string>();
            for (int j = 0; j < mystring.Length; j++)
            {
                ex1.Add(mystring[j]);
            }
            Console.WriteLine($"Длина масива - {ex1.Count}");

            bool continue1 = true;

            while (continue1)
            {
                try
                {
                    Console.WriteLine($"Выберите номер слова от 0 до {ex1.Count - 1} : ");
                    int number = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Выберите направление (l/r) : ");
                    string choice = Console.ReadLine();
                    if (number >= 0 && number < ex1.Count - 1)
                    {
                        if (choice == "l")
                        {
                            for (int i = number; i > 0; i--)
                            {
                                Console.WriteLine(ex1[i]);
                            }
                        }
                        else if (choice == "r")
                        {
                            for (int i = number; i < ex1.Count; i++)
                            {
                                Console.WriteLine(ex1[i]);
                            }
                        }
                        continue1 = false;
                    }     
                }
                catch
                {
                    Console.WriteLine("Не верный ввод");
                    Console.ReadKey();
                    Console.Clear();
                    continue;
                }
            }
                
            Console.ReadKey();
        }
        static void Zadanie2()
        {
            
            try
            {            
                var Dict1 = new Dictionary<int, string>()
                {
                { 1, "Стол" },
                { 3, "Стул" },
                { 4, "Табурет" },
                { 6, "Тумбочка" },
                { 7, "Шкаф" },
                { 9, "Кровать" },
                { 11, "Полка" },
                { 17, "Окно" },
                { 23, "Диван" }

                };
                var Dict2 = new Dictionary<int, string>()
                {
                { 4, "400" },
                { 8, "800" },
                { 11, "1100" },
                { 15, "1500" },
                { 19, "1900" },
                { 23, "2300" },
                { 25, "2500" },
                { 45, "4500" },
                { 109, "1900" }
                };
                var Dict3 = new Dictionary<int, string>()
                {
                { 1, "Один" },
                { 2, "Два" },
                { 3, "Три" },
                { 7, "Семь" },
                { 8, "Восем" },
                { 9, "Девять" },
                { 10, "Десять" },
                { 11, "Одинадцять" },
                { 12, "Двенадцать" }
                };
                var DMass = new List<Dictionary<int, string>>();

                DMass.Add(Dict1);
                DMass.Add(Dict2);
                DMass.Add(Dict3);

                Console.WriteLine("Введите ключ словаря  : ");
                int Key = Convert.ToInt32(Console.ReadLine());
                int Result = 0;
                for (int i = 0; i < DMass.Count(); i++)
                {
                    if (DMass[i].ContainsKey(Key))
                    {
                        string value;
                        DMass[i].TryGetValue(Key, out value);
                        Console.WriteLine($"Найдено елемент по ключю {Key} = {value}");
                        Result++;
                    }
                }
                if(Result == 0) { Console.WriteLine("По вашему ключю не найдено результатов"); };
                Console.ReadKey();
            }
            catch
            {
                Console.WriteLine("Не верный ввод");
                Console.ReadKey();
                Console.Clear();
            }
        }
        static void Zadanie3()
        {
            bool continue1 = true;

            while (continue1)
            {
                Console.Clear();
                try
                {
                    Console.WriteLine("Введите число D от 0 до 9 : ");
                    int number = Convert.ToInt32(Console.ReadLine());
                    bool compare = false;
                    if (number >= 0 && number < 10)
                    {
                        Console.WriteLine("Напишите любые цифры через пробел : ");
                        string numbers = Console.ReadLine();
                        string[] mystring = numbers.Split(' ');
                        var ex3 = new List<int>();
                        for (int i = 0; i < mystring.Length; i++)
                        {
                            ex3.Add(Convert.ToInt32(mystring[i]));
                            if (ex3[i] % 10 == number)
                            {
                                Console.WriteLine("Первое число которое совпадает : {0}",ex3[i]);
                                compare = true;
                                continue1 = false;
                                Console.ReadKey();
                                break;
                            }
                        }
                    }
                    if (compare == false)
                    {
                        Console.WriteLine("Не найдены : 0");
                        continue1 = false;
                        Console.ReadKey();
                    }                    
                }
                catch
                {
                    Console.WriteLine("Не верный ввод");
                    Console.ReadKey();
                    Console.Clear();
                    continue;
                }
            }
        }
    }
}
