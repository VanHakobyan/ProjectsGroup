using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace WorkWithFiles
{
    class Program
    {
        static void Main()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Input the file name !");
            string fileName = Console.ReadLine();
            Console.WriteLine(File.ReadAllText(fileName)) ;
            Console.ReadKey();
        }
    }
}
