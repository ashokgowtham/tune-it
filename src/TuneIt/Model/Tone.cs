using System;

using TuneItInterfaces;

namespace TuneIt.Model
{
    /// <summary>
    /// Tone : time => audioFrame
    /// Tone : takes in time as double and returns an audio frame as double
    /// (it doesn't make sense for this class to contain multiple channel)
    /// </summary>
    public class Tone : IEvaluate
    {
        private readonly Func<double, double> lambda;

        public Tone(Func<double, double> lambdaExpression)
        {
            lambda = lambdaExpression;
        }

        #region IEvaluate Members

        public Func<double, double> Evaluator { get { return lambda; } }

        #endregion
    }
}
