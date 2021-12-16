using System;

namespace _7._2eazy
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите текст:");
            string word = Console.ReadLine();
            Console.WriteLine("Оригинальный текст: " + word);
            word = word.Replace(" ", "");
            Console.WriteLine("Передвинутый текст: " + word);
            Console.ReadLine();
        }
    }
}
