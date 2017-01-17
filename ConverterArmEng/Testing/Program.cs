using System;
using ConverterArmEng;
namespace Testing
{
    class Program
    {
        static void Main(string[] args)
        {
            string arm = "ես տանն եմ";
            string eng = "es tann em";
            Console.WriteLine(eng.ConvertEng()); //es tann em
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine(arm.ConvertEng());
        }
    }
}
