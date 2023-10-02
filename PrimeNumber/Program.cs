// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
static bool IsPrime(int number)
{
    if (number <= 1)
    {
        return false;
    }
    for (int i = 2; i <= Math.Sqrt(number); i++)

    {

        if (number % i == 0)
        {
            return false;
        }
    }
    return true;
}

Console.WriteLine(IsPrime(11));
