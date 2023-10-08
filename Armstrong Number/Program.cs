// Armstrong number is a number that is equal to sum of cubes of its digits.

int number = 153;
int rem;
int cube;
int result = 0;
int temp = number;

while (temp != 0)
{
    rem = temp % 10;
    cube = rem * rem * rem;
    result = result + cube;
    temp = temp / 10;
}

if(number == result)
{
    Console.WriteLine("Amstrong Number");
}
else
{
    Console.WriteLine("Not Amstrong Number");
}

