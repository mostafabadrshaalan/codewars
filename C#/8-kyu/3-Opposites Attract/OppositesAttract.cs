using System;

public class LoveDetector
{
    public static bool lovefunc(int flower1, int flower2)
    {

        Console.WriteLine(string.Format("{0},{1}", flower1, flower2));
        if ((flower1 % 2 == 0) != (flower2 % 2 == 0))
        {
            return true;
        }
        return false;

    }
}