// Write a program that reads five integer numbers and prints their sum. If an invalid number is entered the program should prompt the user to enter another number(only once)


int[] numbers = new int[5];
int sum = 0;

Console.WriteLine("Write 5 integer numbers, press enter after each one: ");
for (int i = 0; i < 5; i++)
{
    try
    {
        numbers[i] = Convert.ToInt32(Console.ReadLine());
        sum = sum + numbers[i];
    }


    catch
    {
        Console.WriteLine("Invalid number, enter another one: ");
        numbers[i] = Convert.ToInt32(Console.ReadLine());
        sum = sum + numbers[i];
    }

}
Console.WriteLine("Their sum is equal to: " + sum);

