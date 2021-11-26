using System;

namespace Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            ArithmeticProgression ap = new ArithmeticProgression();
            GeometricProgression gp = new GeometricProgression();
            Console.WriteLine("Арифметическая прогрессия: \n");
            PrintSeries(ap, 5);
            Console.WriteLine("Геометрическая прогрессия: \n");
            PrintSeries(gp, 5);
        }

        public static void PrintSeries (ISeries series, int count)
        {
            for (int i = 0; i < count; i++)
            {
                series.MoveNext();
                Console.WriteLine(series.GetCurrent());
            }
        }
    }
}
