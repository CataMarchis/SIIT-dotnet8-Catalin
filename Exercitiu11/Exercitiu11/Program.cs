// Write a program that converts a given number from decimal to binary notation (numeral system).

string result = "";
Console.Write(" Give a number to convert to binary: ");
int number = Convert.ToInt32(Console.ReadLine());

while (number >= 1)
{
    int remainder = number % 2;
    result = Convert.ToInt32(remainder) + result;
    number = number / 2;
}

Console.WriteLine(" Binary version of the number is: " + result);





