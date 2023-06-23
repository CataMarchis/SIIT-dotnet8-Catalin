// Write a method that reverses a string if it's length is a multiple of 4

static string reverse(string str)
{
    char[] stringArray = str.ToCharArray();
    if (stringArray.Length % 4 == 0)
        Array.Reverse(stringArray);
    string reversedStr = new(stringArray);
    return reversedStr;
}
Console.WriteLine(reverse("Hellooow"));

