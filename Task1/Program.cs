using System;
/*
 * Group: 182
 * Student: Christian Benua
 * 
 */

class Program
{
    static void Main(string[] args)
    {
        ConsoleKeyInfo keyInfo;
        do
        {
            int currNumber = 0;
            int cntEven = 0;
            do
            {
                Console.Write("Enter Positive Number: ");

                while (!(int.TryParse(Console.ReadLine(), out currNumber) && currNumber >= 0))
                {
                    Console.WriteLine("Something Went Wrong With Your Input, Reenter Positive Number");
                }
                if ((currNumber & 1) == 0 && currNumber != 0)
                {
                    cntEven++;
                }
            } while (currNumber != 0);
            Console.WriteLine("{0} Even Numbers!", cntEven);
            Console.WriteLine("Press esc to exit");
            keyInfo = Console.ReadKey();
        } while (keyInfo.Key != ConsoleKey.Escape);
    }
}

