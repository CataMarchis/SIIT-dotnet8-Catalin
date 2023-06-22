// Write a program that reads from the console two integer numbers (int) and prints how many numbers between them exist that are divisible with 5. such that the remainder of
// their division by 5 is 0.


Console.Write("First number is: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Second number is: ");
int b = Convert.ToInt32(Console.ReadLine());

int dividedWith5 = 0;
if (a < b)
{
    for (int i = a; i < b; i++)
    {
        if (i % 5 == 0)
            dividedWith5++;
    }

}
else if (a > b)
    for (int i = b; i < a; i++)
    {
        if (i % 5 == 0)
            dividedWith5++;
    }


Console.WriteLine("There are " + dividedWith5 + " numbers between " + a + " and " + b + " which are divisible with 5.");