public static class Kata
{
    public static string Usdcny(int usd)
    {
        double youan = usd * 6.75;
        return string.Format("{0:f2} Chinese Yuan", youan);
    }
}