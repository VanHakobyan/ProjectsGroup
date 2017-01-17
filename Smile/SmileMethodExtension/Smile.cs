using System;

namespace SmaileMethodExtension
{
    public static class Smile
    {
        public static string smileMethod(this string smile)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
           
            string retSmile = string.Empty;

            for (int i = 0; i < smile.Length; i++)
            {
                try
                {
                    if (i != smile.Length - 1)
                    {
                        switch (smile)
                        {
                            case ":-)":
                                retSmile += "\u263B";
                                i++;
                                break;
                            case "(S)":
                                retSmile += "\u2600B";
                                i++;
                                break;
                            case "(C)":
                                retSmile += "\u2601B";
                                i++;
                                break;
                            case "(T)":
                                retSmile += "\u31fB";
                                i++;
                                break;
                            case "(Y)":
                                retSmile += "\u262FB";
                                i++;
                                break;
                            case ":-(":
                                retSmile += "\u264DB";
                                i++;
                                break;

                            default:
                                retSmile += smile[i].ToString();
                                break;
                        }
                    }
                }
                catch (IndexOutOfRangeException IOOE)
                {
                    Console.WriteLine(IOOE.Message);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            return retSmile;
        }
    }
}