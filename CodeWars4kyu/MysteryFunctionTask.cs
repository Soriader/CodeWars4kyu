namespace CodeWars4kyu
{
    public class MysteryFunctionTask
    {
        public static long Mystery(long n)
        {
            return n ^ (n >> 1);
        }

        public static long MysteryInv(long n)
        {
            long gray = 0; 
            while (n > 0)
            {
                gray ^= n;  
                n >>= 1; 
            }
            return gray; 
        }

        public static string NameOfMystery()
        {
            return "Gray code";
        }
    }
}
//https://www.codewars.com/kata/56b2abae51646a143400001d/train/csharp