using System;

namespace PadawansTask6
{
    public static class NumberFinder
    {
        public static int? NextBiggerThan(int number)
        {
            char[] chars = number.ToString().ToCharArray();
            char[] sortedChars = new char[chars.Length];
            char[] tmpChars = new char[chars.Length];
            Array.Copy(chars, sortedChars, chars.Length);
            Array.Sort(sortedChars);
            for (int i = number + 1; i < Math.Pow(10, chars.Length); i++)
            {
                Array.Copy(i.ToString().ToCharArray(), tmpChars, chars.Length);
                Array.Sort(tmpChars);
                //if (sortedChars.SequenceEqual(tmpChars)) return i; (LINQ)
                var flag = true;
                for (int k = 0; k < chars.Length; k++)
                    if (sortedChars[k] != tmpChars[k])
                    {
                        flag = false;
                        break;
                    }

                if (flag) return i;
            }

            return null;
        }
    }
}
