public class Kata
{
    public static string StringClean(string s)
    {
        return s.Replace("0", "")
                .Replace("1", "")
                .Replace("2", "")
                .Replace("3", "")
                .Replace("4", "")
                .Replace("5", "")
                .Replace("6", "")
                .Replace("7", "")
                .Replace("8", "")
                .Replace("9", "");
    }
}