// Write a program that reads five numbers from the console and prints the greatest of them.
string[] numbers = { "First number: ", "Second number: ", "Third number: ", "Forth number: ", "Fifth number: " };
int max;


for(int i=0; i<numbers.Length; i++)
{
    
    Console.Write(numbers[i]);
    numbers[i] = Console.ReadLine();
}
max = Convert.ToInt32(numbers[0]);
for (int i=0; i<numbers.Length;i++)
{
    if (Convert.ToInt32(numbers[i]) > max)
    {  max = Convert.ToInt32(numbers[i]);}
}
Console.WriteLine("The greatest number is: " + max);