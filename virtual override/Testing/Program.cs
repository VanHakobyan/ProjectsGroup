using System;
using virtual_override;
namespace Testing
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseClass Base = new BaseClass();
            BaseClass BaseDer = new DerivedClass();
            DerivedClass Der = new DerivedClass();

            Console.ForegroundColor = ConsoleColor.Blue;

            Base.method1();
            Base.method2();
            Base.method3();
            Base.method4();
            Base.method5();

            Console.WriteLine(new string('-', 20));
            Console.ForegroundColor = ConsoleColor.Red;

            BaseDer.method1();
            BaseDer.method2();
            BaseDer.method3();
            BaseDer.method4();
            BaseDer.method5();

            Console.WriteLine(new string('-', 20));
            Console.ForegroundColor = ConsoleColor.Green;

            Der.method1();
            Der.method2();
            Der.method3();
            Der.method4();
            Der.method5();

        }
    }
}
