using System;

namespace Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            //Объявление переменных 
            double val, val1, start;
            //Ввод значений переменных в консоли
            Console.WriteLine("Введите начальное значение: ");
            val = start = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите знаменатель (для геометрической прогрессии): ");
            val1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите количество итераций: ");
            int i = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите нужный номер итерации: ");
            int number = int.Parse(Console.ReadLine());
            //Создание объектов классов
            ArithmeticProgression ap = new ArithmeticProgression(val, start);
            GeometricProgression gp = new GeometricProgression(val, start, val1);
            //Вывод результатов арифметической прогрессии
            Console.WriteLine("Арифметическая прогрессия:");
            Console.WriteLine(val);
            PrintSeries(ap, i);
            PrintIndex(ap, number);
            //Вывод результатов геометрической прогрессии
            Console.WriteLine("Геометрическая прогрессия:");
            Console.WriteLine(val);
            PrintSeries(gp, i);
            PrintIndex(gp, number);
        }

        //Метод для создания массива результатов прогрессии
        public static void PrintSeries(ISeries series, int count)
        {
            for (int i = 0; i < count; i++)
            {
                series.MoveNext();
                Console.WriteLine(series.GetCurrent());
            }
        }

        //Метод для вывода определенного результата прогрессии
        public static void PrintIndex(ISeries series, int count)
        {
            series.Reset();
            for (int i = 1; i <= count; i++)
            {
                if (i == count)
                    Console.WriteLine("Результат {0} итерации: {1}\n", count, series.GetCurrent());
                else
                    series.GetCurrent();
            }
        }
    }
}
