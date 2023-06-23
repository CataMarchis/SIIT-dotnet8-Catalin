// Write a program that reads from the console a series of 5 integers and prints the smallest and largest of them.

int[] integers = new int[5];
int min;
int max;

Console.WriteLine(" Type 5 numbers: ");
for (int i = 0; i < 5; i++)
{
    integers[i] = Convert.ToInt32(Console.ReadLine());
}
min = integers[0];
max = integers[0];
for (int i = 0; i < 5; i++)
{
    if (integers[i] < min)
    {
        min = integers[i];
    }
    else if (integers[i] > max)
    {
        max = integers[i];
    }
}
Console.WriteLine("Smallest number is " + min + " and largest number is " + max);