using System;
using System.Collections.Generic;
using System.Text;

namespace Interface
{
    public interface ISeries
    {
        double GetCurrent();
        bool MoveNext();
        void Reset();
    }
}
