// Write a program that prints on the console the numbers from 1 to N. The number N should be read from the standard input.


Console.Write("Type a number: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("All the numbers from 1 to " + n + " are: ");

for(int i = 0; i <= n; i++)
{
    Console.WriteLine(i);
}