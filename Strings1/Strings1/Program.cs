//Write a method that to remove the characters which have odd index values of a given string.

string str = "Hello, how are you?";

static string removeOdd(string strin)
{
    string strin2 = "";
    for(int i = 0; i < strin.Length; i++)
    {
        if (i % 2 == 0)
            strin2 = strin2 + strin[i];
    }
    return strin2;
}


Console.WriteLine(removeOdd(str));