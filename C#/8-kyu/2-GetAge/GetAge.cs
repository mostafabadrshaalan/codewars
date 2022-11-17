using System;

public class Kata
{
    public static int GetAge(string inputString)
    {
        return Convert.ToInt32(inputString[0] - '0');
    }
}