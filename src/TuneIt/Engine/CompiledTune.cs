using System;

namespace TuneIt.Engine
{
    /// <summary>
    /// CompiledTune : time => audioFrame
    /// CompiledTune represents a turingmachine which takes in time instances as double
    /// and returns audio frames (can include multiple channels)
    /// </summary>
    public class CompiledTune : IEvaluate
    {
        private readonly Func<double, double> evaluator;

        public CompiledTune(Func<double, double> evaluator)
        {
            this.evaluator = evaluator;
        }

        #region IEvaluate<double> Members

        public Func<double, double> Evaluator { get { return evaluator; } }

        #endregion
    }
}
