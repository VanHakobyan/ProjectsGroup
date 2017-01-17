using System.Collections.Generic;

namespace EnglishArmToArmeninArm
{
    public static class Translate
    {

        public static string ArmTo(this string sentence)
        {
            sentence.ToLower();
            string text = string.Empty;
            int count = 0;
            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            dictionary.Add("a", "ա");
            dictionary.Add("d", "դ");
            dictionary.Add("e", "ե");
            dictionary.Add("b", "բ");
            dictionary.Add("th", "թ");
            dictionary.Add("z", "զ");
            dictionary.Add("i", "ի");
            dictionary.Add("l", "լ");
            dictionary.Add("@", "ը");
            dictionary.Add("g", "գ");
            dictionary.Add("ts", "ծ");
            dictionary.Add("k", "կ");
            dictionary.Add("x", "խ");
            dictionary.Add("dz", "ձ");
            dictionary.Add("gh", "ղ");
            dictionary.Add("h", "հ");
            dictionary.Add("y", "յ");
            dictionary.Add("ch", "չ");
            dictionary.Add("n", "ն");
            dictionary.Add("sh", "շ");
            dictionary.Add("m", "մ");
            dictionary.Add("v", "վ");
            dictionary.Add("p", "պ");
            dictionary.Add("o", "ո");
            dictionary.Add("s", "ս");
            dictionary.Add("j", "ջ");
            dictionary.Add("t", "տ");
            dictionary.Add("ph", "փ");
            dictionary.Add("r", "ր");
            dictionary.Add("c", "ց");
            dictionary.Add("u", "ու");
            dictionary.Add("q", "ք");
            dictionary.Add("ev", "և");
            dictionary.Add("f", "ֆ");
            dictionary.Add(",", ",");
            dictionary.Add(";", ";");
            dictionary.Add("_", "_");
            dictionary.Add(":", ":");
            dictionary.Add(" ", " ");
            dictionary.Add("!", "!");


            while (count < sentence.Length)
            {
                if (sentence[count] == 't' && sentence[count + 1] == 's')
                {
                    text += dictionary["ts"];
                    count += 2;
                    continue;
                }
                if (sentence[count] == 'd' && sentence[count + 1] == 'z')
                {
                    text += dictionary["dz"];
                    count += 2;
                    continue;
                }
                if (sentence[count] == 'g' && sentence[count + 1] == 'h')
                {
                    text += dictionary["gh"];
                    count += 2;
                    continue;
                }
                if (sentence[count] == 't' && sentence[count + 1] == 'h')
                {
                    text += dictionary["th"];
                    count += 2;
                    continue;
                }
                if (sentence[count] == 's' && sentence[count + 1] == 'h')
                {
                    text += dictionary["sh"];
                    count += 2;
                    continue;
                }
                if (sentence[count] == 'c' && sentence[count + 1] == 'h')
                {
                    text += dictionary["ch"];
                    count += 2;
                    continue;
                }
                if (sentence[count] == 'p' && sentence[count + 1] == 'h')
                {
                    text += dictionary["ph"];
                    count += 2;
                    continue;
                }
                if (sentence[count] == 'e' && sentence[count + 1] == 'v')
                {
                    text += dictionary["ev"];
                    count += 2;
                    continue;

                }
                text += dictionary[sentence[count].ToString()];
                count++;
            } 
            return text;
        }
    }
}
