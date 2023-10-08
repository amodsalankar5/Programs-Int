// See https://aka.ms/new-console-template for more information

// Factorial e.g. 5!
// 5*4*3*2*1 = 120

static int Factorial(int number)
{
    int factorial = 1;
    for (int i = number; i >= 1; i--)
    {
        factorial = factorial * i;
    }

    return factorial;
}

Console.WriteLine(Factorial(0));
