using System;
using System.IO;
namespace WorkWithFiles01
{
    class Program
    {
        static void Main()
        {

            using (var sw = File.AppendText(@"D:\text.txt"))
            {
                sw.WriteLine("Input text text.txt");
            }
        }
    }
}
