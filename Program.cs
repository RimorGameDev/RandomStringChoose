using System;

namespace RandomMapGen
{
    internal class Program
    {
        public static string[] maps = { "Alpha", "Beta", "Supreme" };

        public static void Main(string[] args)
        {
            string choose = maps[new Random().Next(0, maps.Length)]; //Сохраняем значения рандома...

            Console.WriteLine("Добро пожаловать в случайный генератор карт!");
            Console.ReadKey();

            Console.WriteLine("У нас есть три карты : {0}, {1}, {2}", maps[0], maps[1], maps[2]);
            Console.ReadKey();

            Console.WriteLine("Сейчас мы выберем случайную карту...");
            Console.ReadKey();

            Console.WriteLine("И мы выбираем: " + maps[new Random().Next(0, maps.Length)]); //Обращаемся к классу Random , к функции Next и считаем случайную строку от 0 до длинны массива
            Console.ReadKey();

            if (choose == maps[0])
            {
                AlphaMap();
            }
            else if (choose == maps[1])
            {
                BetaMap();
            }
            else if (choose == maps[2])
            {
                SupremeMap();
            }

            Console.ReadKey();
        }

        private static void AlphaMap()
        {
            Console.WriteLine("Добро пожаловать на карту " + maps[0]);
        }

        private static void BetaMap()
        {
            Console.WriteLine("Добро пожаловать на карту " + maps[1]);
        }

        private static void SupremeMap()
        {
            Console.WriteLine("Добро пожаловать на карту " + maps[2]);
        }
    }
}