using System;
using System.Text;
using SmaileMethodExtension;

namespace testingSmile
{
    class Program
    {
        static void Main(string[] args)
        {
           
                Console.OutputEncoding = Encoding.UTF8;
                Console.WriteLine("Մուտքագրեք smile");
                string smile = Console.ReadLine();
                Console.WriteLine(smile.smileMethod());

            
        }
    }
}
