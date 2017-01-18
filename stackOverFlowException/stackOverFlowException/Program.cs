using System;

namespace stackOverFlowException
{
    class Program
    {
        public static void method()
        {
            int[] array = new int[100];
            Console.WriteLine(array);
            method(); //recursion
        }

        static void Main()
        {
            try
            {
                method();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {   
                //finally does not work
                Console.WriteLine("i am finally");
            }
        }
    }
}
