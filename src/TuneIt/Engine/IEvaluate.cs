using System;

namespace TuneIt.Engine
{
    public interface IEvaluate
    {
        Func<double, double> Evaluator { get; }
    }
}
