using System;

class Program
{
    
    static bool IsPrime(int num)
    {
        if (num < 2) return false;
        for (int i = 2; i * i <= num; i++)
            if (num % i == 0) return false;
        return true;
    }

    static void Main(string[] args)
    {
        // Bütün case-lər yoxlanır
        for (int num = 1; num <= 30; num++)
            Console.WriteLine("{0}: {1}", num, IsPrime(num) ? "Sadə ədəddir" : "Mürəkkəb ədəddir");
    }
}
