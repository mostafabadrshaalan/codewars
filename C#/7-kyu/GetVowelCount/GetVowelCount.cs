public static int GetVowelCount(string str)
{
    int newstr = 0;
    foreach (char s in str)
    {
        if (IsVowel(s))
        {
            newstr++;
        }
    }
    return newstr;
}
private static bool IsVowel(char s)
{
    return (s == 'a' || s == 'i' || s == 'o' || s == 'u' || s == 'e');
}