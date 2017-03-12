namespace Extension01
{
    public static class symmetrical
    {
        public static bool isSymmetrical(this string word)
        {

            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] != word[word.Length - i - 1])
                    return false;

            }
            return true;

        }
    }
}
