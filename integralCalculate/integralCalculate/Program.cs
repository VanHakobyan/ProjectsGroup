using System;

namespace integralCalculate
{
    class Program
    {
        delegate double integral(double x, int y, int z);
        delegate double integrateDelegate(double x ,double t, int y, int z);

        public static double pValue(double fStatistic, int degreeNum, int degreeDenom)
        {
            double pValue = 0;
            pValue = integrate(0, fStatistic, degreeNum, degreeDenom);

            return pValue;

        }

        public static double integrate(double start, double end, int degreeFreedomT, int degreeFreedomE)
        {
            int iterations = 100000;
            double x, dist, sum = 0, sumT = 0;
            dist = (end - start) / iterations;
            for (int i = 1; i <= iterations; i++)
            {
                x = start + i * dist;
                sumT += integralFunction(x - dist / 2, degreeFreedomT, degreeFreedomE);
                if (i < iterations)
                {
                    sum += integralFunction(x, degreeFreedomT, degreeFreedomE);
                }
            }
            sum = (dist / 6) * (integralFunction(start, degreeFreedomT, degreeFreedomE) + integralFunction(end, degreeFreedomT, degreeFreedomE) + 2 * sum + 4 * sumT);
            return sum;
        }

        public static double integralFunction(double x, int degreeFreedomT, int degreeFreedomE)
        {
            double temp = 0;
            temp = ((Math.Pow(degreeFreedomE, degreeFreedomE / 2) * Math.Pow(degreeFreedomT, degreeFreedomT / 2)) / (factorial(degreeFreedomE / 2 - 1) * factorial(degreeFreedomT / 2 - 1))) * (factorial(((degreeFreedomT + degreeFreedomE) / 2 - 1))) * ((Math.Pow(x, degreeFreedomE / 2 - 1)) / (Math.Pow((degreeFreedomT + degreeFreedomE * x), ((degreeFreedomE + degreeFreedomT) / 2))));
            return temp;
        }

        public static double factorial(double n)
        {
            if (n == 0)
            {
                return 1.0;
            }
            else
            {
                return n * factorial(n - 1);
            }
        }
        static integral value1 = pValue;
        static integrateDelegate inter = integrate;

        static void Main()
        {
            Console.WriteLine(value1.Invoke(1.2, 4, 6));
            Console.WriteLine(inter.Invoke(1.2, 2.1, 5, 9));
        }
    }
}
