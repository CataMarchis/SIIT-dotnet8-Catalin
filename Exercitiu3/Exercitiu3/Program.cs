// Write a program that reads from the console the radius "r" of a circle and prints its perimeter and area.


double pi = Math.PI; 
Console.Write("Circle radius is: ");
double r = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Perimeter equals to: " + (2*pi*r));
Console.WriteLine("Area of the circle equals to: " + (pi * r * r));