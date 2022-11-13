using System;
public class Kata
{
    public static int[] Flip(char dir, int[] arr)
    {
        if (dir == 'R')
        {
            Array.Sort(arr);
            return arr;
        }
        else if (dir == 'L')
        {
            Array.Sort(arr);
            Array.Reverse(arr);
            return arr;
        }

        return new int[] { }; ;
    }
}