using System;
public static class JadenCase
{
    public static string ToJadenCase(this string phrase)
    {
        string newstr = "";
        string[] newphrase = phrase.Split();
        foreach (string s in newphrase)
        {
            newstr += s[0].ToString().ToUpper() + s.Substring(1, s.Length - 1) + " ";
        }
        return newstr.Substring(0, newstr.Length - 1);

    }
}