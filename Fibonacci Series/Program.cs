﻿// Fibonacci series means series of numbers whose next number will be addition of previous two numbers.

int a = 0;
int b = 1;
int c;

Console.WriteLine(a);
Console.WriteLine(b);

for (int i = 0; i < 5; i++)
{
    c = a + b;
    Console.WriteLine(c);

    a = b;
    b = c;
}



