using System;


class Program
{
    public static double binPow(double a, int n) {
        if (n == 0) {
            return 1;
        }
        if (n % 2 == 1) {
            return a * binPow(a, n - 1);
        } else {
            return binPow(a * a, n / 2);
        }
    }

    static void Main(string[] args)
    {
        ConsoleKeyInfo keyInfo;
        do
        {
            Console.WriteLine("Enter a value for a^{n} expression:");
            double a;
            int b;
            while (!double.TryParse(Console.ReadLine(), out a) || !int.TryParse(Console.ReadLine(), out b))
            {
                Console.WriteLine("Smth Wrong With Your Input, pls, Reenter: ");
            }
            Console.WriteLine("Result: " + binPow(a, b).ToString("F3"));
            Console.WriteLine("To exit enter ESC");
            keyInfo = Console.ReadKey();
        } while (keyInfo.Key != ConsoleKey.Escape);

    }
}

