using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L12;

internal class Variable
{
    public string Name { get; init; }
    public bool IsBasis;
    public double Multiplier;
    public double[] Values;

    public double Mark;

    public Variable(string name, double multiplier, double[] values)
    {
        Name = name;
        Multiplier = multiplier;
        Values = values;
    }
}
