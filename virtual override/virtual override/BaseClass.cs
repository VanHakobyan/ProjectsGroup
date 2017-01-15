using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace virtual_override
{
    public class BaseClass
    {
        public virtual void method1()
        {
            Console.WriteLine("Virtual method1 in BaseClass");
        }
        public virtual void method2()
        {
            Console.WriteLine("Virtual method2 in BaseClass");
        }
        public virtual void method3()
        {
            Console.WriteLine("Virtual method3 in BaseClass");
        }
        public void method4()
        {
            Console.WriteLine("method4 in BaseClass");
        }
        public void method5()
        {
            Console.WriteLine("method5 in BaseClass");
        }

    }
}
