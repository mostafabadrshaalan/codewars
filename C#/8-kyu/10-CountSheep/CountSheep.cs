using System;

public static class Kata
{
    public static string CountSheep(int n)
    {
        string res = "";
        for (int i = 1; i <= n; i++)
        {
            res += string.Format("{0} sheep...", i);
        }
        return res;
    }
}