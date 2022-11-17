public class Kata
{
    public static string DoubleChar(string s)
    {
        string str = "";
        char[] chararr = s.ToCharArray();
        foreach (char c in chararr)
        {
            str += c + "" + c;
        }
        return str;
    }
}