using System;


class Program
{
    static void Main(string[] args)
    {
        ConsoleKeyInfo keyInfo;
        do
        {
            Console.WriteLine("Enter Celsium temperature:");
            int celsiumTemp;
            while (!(int.TryParse(Console.ReadLine(), out celsiumTemp) && celsiumTemp >= -273))
            {
                Console.WriteLine("Something wrong with your Input, Reenter:");
            }
            Console.WriteLine("Fahrenheit: " + ((double)(celsiumTemp) * 9 / 5 + 32).ToString("F3"));
            Console.WriteLine("Kalvin:     " + (celsiumTemp + 273.15));
            Console.WriteLine("Rankin:     " + ((double)(celsiumTemp + 273.15) * 9 / 5).ToString("F3"));
            Console.WriteLine("Delisle:    " + ((double)(100 - celsiumTemp) * 3 / 2).ToString("F3"));
            Console.WriteLine("Newton:     " + ((double)(celsiumTemp) * 33 / 100).ToString("F3"));
            Console.WriteLine("Reaumur:    " + ((double)celsiumTemp * 4 / 5).ToString("F3"));
            Console.WriteLine("Rømer:      " + ((double)celsiumTemp * 21 / 40 + 7.5).ToString("F3"));
            Console.WriteLine("To exit enter ESC");
            keyInfo = Console.ReadKey();
        } while (keyInfo.Key != ConsoleKey.Escape);
    }
}

