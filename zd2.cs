using System;
using System.Collections.Generic;

class Program
{
    static List<int> Eratos(int num)
    {
        List<int> numbersToNum = new List<int>();
        List<int> Prostie = new List<int>();

        for (int i = 0; i < num; i++)
        {
            numbersToNum.Add(i);
        }

        for (int i = 2; i < num; i++)
        {
            if (numbersToNum[i] != 0)
            {
                for (int j = i + numbersToNum[i]; j < num; j += numbersToNum[i])
                {
                    numbersToNum[j] = 0;
                }
            }
        }

        for (int i = 0; i < num; i++)
        {
            if (numbersToNum[i] != 0 && numbersToNum[i] != 1)
            {
                Prostie.Add(numbersToNum[i]);
            }
        }

        return Prostie;
    }

    static int Moded(int number, int m)
    {
        int result = 1;

        for (int i = 0; i < m; i++)
        {
            result *= number;
            result %= (m + 1);
        }

        return result;
    }

    static void Main()
    {
        // Example usage
        List<int> primes = Eratos(20);
        foreach (int prime in primes)
        {
            Console.Write(prime + " ");
        }
        Console.WriteLine();

        int result = Moded(5, 7);
        Console.WriteLine(result);
    }
}
