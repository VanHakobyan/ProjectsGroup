using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace virtual_override
{
    public class DerivedClass : BaseClass
    {
        public override void method1()
        {
            Console.WriteLine("Virtual method1 in DiravedClass ");
        }
        public new void method2()
        {
            Console.WriteLine("Virtual method2 in DiravedClass ");
        }
        public void method3()
        {
            Console.WriteLine("Virtual method3 in DiravedClass ");
        }
        public new void method4()
        {
            Console.WriteLine("Virtual method4 in DiravedClass ");
        }
        public void method5()
        {
            Console.WriteLine("Virtual method5 in DiravedClass ");
        }
    }
}
