// Write a program that prints on the console the numbers from 1 to N, which are not divisible by 3 and 7 simultaneously. The number N should be read from the standard input.

Console.Write("Type a number: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("All the numbers from 1 to " + n + " , which are not divisible by 3 and 7 simultaneously are : ");

for (int i = 0; i <= n; i++)
{
    if (i % 3 != 0 || i % 7 != 0)
    Console.WriteLine(i);
}