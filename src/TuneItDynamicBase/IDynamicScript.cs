using System;

namespace TuneItDynamicBase
{
    public interface IDynamicScript
    {
        Func<double, double> Evaluator { get; }
    }
}
