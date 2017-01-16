using System;
using Extension;
namespace Testing
{
    class Program
    {
        static void Main()
        {
            string st1 = "Anna";
            string st2 = "AramarA";
            string st3 = "aNNa";
            string st4 = "ՀայաՀ";
            string st5 = Console.ReadLine();
            Console.WriteLine(st1.isSymmetrical());//false
            Console.WriteLine(st2.isSymmetrical());//true
            Console.WriteLine(st3.isSymmetrical());//true
            Console.WriteLine(st4.isSymmetrical());//true
            Console.WriteLine(st5.isSymmetrical());

        }
    }
}
