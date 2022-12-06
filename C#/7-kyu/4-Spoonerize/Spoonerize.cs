using System;

public static class ReadySet
{
    public static string Spoonerize(string str)
    {
        string[] words = str.Split(' ');
        if (words.Length == 2)
        {
            return words[1][0] + words[0][1..] + ' ' + words[0][0] + words[1][1..];
        }
        else
        {
            return words[1][0] + words[0][1..] + " " + words[1] + " " + words[0][0] + words[2][1..];
        }
    }
}