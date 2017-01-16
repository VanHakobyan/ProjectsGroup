using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extension
{
    public static class symmetrical
    {
        public static bool isSymmetrical(this string word)
        {

            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] != word[word.Length-1 - i])
                    return false;

            }
            return true;

        }
    }
}
