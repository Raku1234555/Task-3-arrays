using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int n = int.Parse(Console.ReadLine());


        SieveOfEratosthenes(n);
    }

    static void SieveOfEratosthenes(int n)
    {

        bool[] isPrime = new bool[n + 1];


        for (int i = 2; i <= n; i++)
        {
            isPrime[i] = true;
        }


        for (int i = 2; i * i <= n; i++)
        {
            if (isPrime[i])
            {
                for (int j = i * i; j <= n; j += i)
                {
                    isPrime[j] = false;
                }
            }
        }


        Console.WriteLine("Prime numbers between 1 and " + n + ":");
        for (int i = 2; i <= n; i++)
        {
            if (isPrime[i])
            {
                Console.Write(i + " ");
            }
        }
    }
}
