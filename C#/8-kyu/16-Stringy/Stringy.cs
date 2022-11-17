public class Kata
{
    public static string Stringy(int size)
    {
        string end = "";
        while (end.Length < size)
        {
            end += "1";
            if (end.Length < size)
            {
                end += "0";
            }
        }
        return end;
    }
}