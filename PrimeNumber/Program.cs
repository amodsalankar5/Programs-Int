// See https://aka.ms/new-console-template for more information

//Note: 1. Prime Number is which is divided by "1 and itself" only
//2. 2 is FIRST PRIME NUMBER
//3. e.g. 2, 3, 5, 7, 11, 13, .....
using System.Security.Cryptography.X509Certificates;

#region Find is Prime number:
static bool IsPrime(int number)
{
    if (number <= 1)
    {
        return false;
    }
    else
    {
        int count = 0;
        //bool isPrime = false;
        for (int i = 1; i <= number; i++)
        {
            if (number % i == 0)
            {
                count++;
            }
        }
        //isPrime = count == 2 ? true : false;
        //return isPrime;
        return count == 2;
    }
}

Console.WriteLine(IsPrime(2));

#endregion


#region Find Prime numbers till Nuber:

//PNTillNumber(100);

void PNTillNumber(int number)
{
    for (int i = 2; i <= number; i++)
    {
        if (IsPrime(i))
        {
            Console.WriteLine(i);
        };
        //number--;
    }
}

#endregion