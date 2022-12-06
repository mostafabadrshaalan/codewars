using System;
using System.Collections.Generic;
using System.Linq;

public class Kata
{
    public static IEnumerable<string> OpenOrSenior(int[][] data)
    {
        string[] arr = new string[data.Length];
        for (int i = 0; i < data.Length; i++)
        {
            for (int j = 0; j < data[i].Length; j++)
            {
                if (data[i][0] >= 55 && data[i][1] > 7)
                {
                    arr[i] = "Senior";
                }
                else
                {
                    arr[i] = "Open";
                }
            }
        }

        return arr;
    }
}