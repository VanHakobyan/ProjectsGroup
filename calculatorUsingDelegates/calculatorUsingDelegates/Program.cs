using System;

namespace calculatorUsingDelegates
{
    class Program
    {
        public delegate float MyDelegate(float x, float y);

        static void Main(string[] args)
        {
            try
            {
                Console.Write("Argument one:  ");
                float one = float.Parse(Console.ReadLine());
                Console.Write("Argument two:  ");
                float two = float.Parse(Console.ReadLine());
            }
            catch (FormatException fe)
            {
                Console.WriteLine(fe.Message);
                Console.WriteLine("imput number");
            }
            Console.Write("input: + , - , * or / :  ");
        st: string st = Console.ReadLine();

            if (st != "+" && st != "*" && st != "-" && st != "/")
            {
                Console.WriteLine("false symbols write again");
                goto st;
            }
            MyDelegate op = null;
            switch (st)
            {
                case "+":
                    op = (x, y) => x + y;
                    break;
                case "-":
                    op = (x, y) => x - y;
                    break;
                case "*":
                    op = (x, y) => x * y;
                    break;
                case "/":
                    try
                    {
                        op = (x, y) => x / y;
                    }
                    catch (DivideByZeroException DBZE)
                    {
                        Console.WriteLine(DBZE.Message);
                        Console.WriteLine("argument two = 0");
                    }
                    break;
            }

            Console.WriteLine(new string('-', 25));
            if (op != null)
                Console.WriteLine($"{one}{st}{two}={op(one, two)}");
            Console.ReadKey();
        }
    }
}
