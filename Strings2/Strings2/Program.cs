// Write a method that takes input from the user and displays that input back in upper and lower cases.


static void display()
{
    Console.Write("Write a string: ");
    string str = Console.ReadLine();
    string upper = str.ToUpper();
    string lower = str.ToLower();
    Console.WriteLine("Given string to upper case: " + upper);
    Console.WriteLine("Given string to lower case: " + lower);
}

display();
