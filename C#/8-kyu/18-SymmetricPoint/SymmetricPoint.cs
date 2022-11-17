public class Kata
{
    public static int[] SymmetricPoint(int[] p, int[] q)
    {
        int[] dis = { 0, 0 };
        int[] p1 = { 0, 0 };

        for (int i = 0; i < p.Length; i++)
        {
            dis[i] = p[i] - q[i];
        }

        for (int x = 0; x < dis.Length; x++)
        {
            p1[x] = q[x] - dis[x];
        }
        return p1;
    }
}