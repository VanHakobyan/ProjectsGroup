using System;
using virtual_override;
namespace Testing
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseClass Base = new BaseClass();
            BaseClass BaseDir = new DiravedClass();
            DiravedClass Dir = new DiravedClass();

            Console.ForegroundColor = ConsoleColor.Blue;

            Base.method1();
            Base.method2();
            Base.method3();
            Base.method4();
            Base.method5();

            Console.WriteLine(new string('-', 20));
            Console.ForegroundColor = ConsoleColor.Red;

            BaseDir.method1();
            BaseDir.method2();
            BaseDir.method3();
            BaseDir.method4();
            BaseDir.method5();

            Console.WriteLine(new string('-', 20));
            Console.ForegroundColor = ConsoleColor.Green;

            Dir.method1();
            Dir.method2();
            Dir.method3();
            Dir.method4();
            Dir.method5();

        }
    }
}
