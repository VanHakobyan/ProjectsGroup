using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vector;
namespace Testing
{
    class Program
    {
        static void Main(string[] args)
        {
            vector vec1 = new vector(2, 1);
            vector vec2 = new vector(1, 1);
            vector vec = new vector(0, 0);
            vec = vec1 + vec2;
            Console.WriteLine(vec);


            
        }
    }
}
