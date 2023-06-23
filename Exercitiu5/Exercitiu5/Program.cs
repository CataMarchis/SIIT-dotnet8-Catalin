// Write a program that reads two numbers from the console and prints the greater of them. Solve the problem without using conditional statements and with conditional statements.

Console.Write("First number: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Second number: ");
int b = Convert.ToInt32(Console.ReadLine());

if (a > b)
    Console.WriteLine("First number is greater.");
else if (a < b)
    Console.WriteLine("Second number is greater.");
else Console.WriteLine("Equal numbers.");