// Palindrome number is whose reverse is aslo the same number.
// e.g. 121, 444, 767, etc.
// % => Gives the Reminder 
// / => Gives the Quotient


    //       12 => Quotient
    //    _______
    //  10)  121
    //     - 120
    //     ______
    //         1 => Reminder

int number = 121;
int rem;
int result = 0;
int temp = number;

while (temp != 0)
{
    rem = temp % 10;    // Gives Reminder 
    result = result * 10 + rem;
    temp = temp / 10;   // Gives Quotient
}

if (number == result)
{
    Console.WriteLine("Palindrome Number");
}
else
{
    Console.WriteLine("Not Palindrome Number");
}