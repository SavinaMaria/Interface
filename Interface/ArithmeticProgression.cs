using System;
using System.Collections.Generic;
using System.Text;

namespace Interface
{
    class ArithmeticProgression : IIndexableSeries
    {
        double IIndexable.this[int index] => throw new NotImplementedException();
        int start = 2;
        int val = 2;
        double ISeries.GetCurrent()//Текущий элемент
        {
            val += val;
            return val;
        }

        bool ISeries.MoveNext()//Перейти к следующему
        {
            return true;
        }

        void ISeries.Reset()//Начать заново
        {
            val = start;
        }

    }
}
