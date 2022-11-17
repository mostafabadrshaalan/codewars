public class Kata
{
    public static int SameCase(char a, char b)
    {
        if (!char.IsLetter(a) || !char.IsLetter(b))
        {
            return -1;
        }
        else if (char.IsUpper(a) && char.IsUpper(b))
        {
            return 1;
        }
        else if (char.IsLower(a) && char.IsLower(b))
        {
            return 1;
        }

        return 0;
    }
}