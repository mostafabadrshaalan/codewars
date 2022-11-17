using System.Linq;
using System.Collections.Generic;
public class Kata

{
    public static bool BetterThanAverage(int[] ClassPoints, int YourPoints)
    {
        List<int> lst = ClassPoints.OfType<int>().ToList();
        lst.Add(YourPoints);
        double all = 0;
        foreach (int s in lst)
        {
            all += s;
        }
        double avg = all / lst.Count;
        if (YourPoints > avg)
            return true;
        else return false;
    }
}