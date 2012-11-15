using System;

namespace TuneItInterfaces
{
    public interface IEvaluate
    {
        Func<double, double> Evaluator { get; }
    }
}
