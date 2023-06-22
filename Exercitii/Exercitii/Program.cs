// Write a program that reads from the console three numbers of type int and prints their sum.

Console.WriteLine("Write 3 numbers: ");

Console.WriteLine("First number: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Second number: ");
int b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Third number: ");
int c = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Sum of these numbers is: " + (a + b + c));