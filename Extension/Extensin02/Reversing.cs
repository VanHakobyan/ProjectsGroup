namespace Extension02
{
    public static class Reversing
    {
        public static string reversing(this string s)
        {
            string st = string.Empty;
            for (int i = 0; i < s.Length; i++)
            {
                st += s[s.Length - 1 - i];

            }
            return st;
        }
    }
}
