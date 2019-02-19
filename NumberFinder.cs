using System;

namespace PadawansTask6
{
    public static class NumberFinder
    {
        public static int? NextBiggerThan(int number)
        {
            if (number < 0) throw new ArgumentException();
            char[] chars = number.ToString().ToCharArray();
            for (int i = chars.Length - 2; i >= 0; i--)
            for (int j = chars.Length - 1; j > i; j--)
            {
                if (chars[i] < chars[j])
                {
                    var k = chars[i];
                    chars[i] = chars[j];
                    chars[j] = k;
                    Array.Sort(chars, i + 1, chars.Length - i - 1);
                    if (Convert.ToInt64(new string(chars)) > Int32.MaxValue) return null;
                    return Convert.ToInt32(new string(chars));
                }
            }

            return null;
        }
    }
}
