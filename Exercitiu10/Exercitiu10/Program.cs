// Write program that outputs a triangle made of stars with variable size, depending on an input parameter. Look at the examples to get an idea. The input comes as a string number,
//which needs to be parsed to a number. The output is a series of lines printed on the console, forming a triangle of variable size.

Console.Write("Give piramid size: ");
int size = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i <= size; i++)
{
    string line = new string('*', i);
    Console.WriteLine(line);
}

for (int i = size - 1; i >= 1; i--)
{
    string line = new string('*', i);
    Console.WriteLine(line);
}
