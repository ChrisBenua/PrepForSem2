using System;


class Program
{
    static void Main(string[] args)
    {
        ConsoleKeyInfo keyInfo;
        do
        {
            int number = 0;
            Console.WriteLine("Enter the number > 999");
            while (!(int.TryParse(Console.ReadLine(), out number) && number > 999))
            {
                Console.WriteLine("Smth Wrong With Your Input, Pls, Reenter Number");
            }
            Console.WriteLine((number / 100) % 10);
            Console.WriteLine("Press Esc to Exit");
            keyInfo = Console.ReadKey();
        } while (keyInfo.Key != ConsoleKey.Escape);
    }
}

