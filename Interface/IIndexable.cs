using System;
using System.Collections.Generic;
using System.Text;

namespace Interface
{
    public interface IIndexable
    {
        double this[int index] { get; }
    }
}
