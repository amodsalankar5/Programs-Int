// Swappig of two numbers:
// There are two Approaches
// 1. Using Three Variable
// 2. Using two variables -- This Approach need to remember formula

ThreeVariables();
TwoVariables();

#region Three Variable Approach
void ThreeVariables()
{
    int a = 1;
    int b = 2;
    int c;

    Console.WriteLine("Before swapping {0} {1}", a, b);

    c = a;
    a = b;
    b = c;

    Console.WriteLine("After swapping {0} {1}", a, b);
}

#endregion

#region Two Variable Approach
void TwoVariables()
{
    int a = 1;
    int b = 2;

    Console.WriteLine("Before swapping {0} {1}", a, b);

    a = a + b;
    b = a - b;
    a = a - b;

    Console.WriteLine("After swapping {0} {1}", a, b);

}

#endregion
