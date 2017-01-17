using System;
using EnglishArmToArmeninArm;
using System.Threading;
namespace TranslateThis
{
    class Program
    {
        static void Main()
        {
            Thread.Sleep(200);
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Thread.Sleep(300);
            Console.ForegroundColor = ConsoleColor.Red;
           
            Console.WriteLine("Write your sentence in English keyword");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Գրեք ձեր տեքստը լատինատառ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            string sentence = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(sentence.ArmTo());
            Console.ReadKey();
        }
    }
}
