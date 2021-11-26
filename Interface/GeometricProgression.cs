using System;
using System.Collections.Generic;
using System.Text;

namespace Interface
{
    class GeometricProgression : IIndexableSeries
    {
        double IIndexable.this[int index] => throw new NotImplementedException();

        int start = 2;
        int val = 2;
        int val1 = 4;

        double ISeries.GetCurrent()
        {
            val  = val * val1;
            return val;
        }
         
        bool ISeries.MoveNext()
        {
            return true;
        }

        void ISeries.Reset()
        {
            val = start;
        }


    }
}
