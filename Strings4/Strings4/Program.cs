// Write method to convert a given string to all uppercase if it contains at least 2 uppercase characters in the first 4 characters.
using System;

static string convertToUpper(string str)
{
    int nrOfUpper = 0;

    for (int i = 0; i < 4; i++)
    {
        if (char.IsUpper(str[i]))
        {
            nrOfUpper++;
        }
    }
    if (nrOfUpper >= 2)
    {
        return str.ToUpper();
    }
    return str;
}
string myString = "Hellooo";
Console.WriteLine(convertToUpper(myString));