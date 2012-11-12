using System;

namespace TuneIt.Model
{
    /// <summary>
    /// Tone : time => audioFrame
    /// </summary>
    public class Tone
    {
        private readonly string expression;
        private readonly Func<double, double> lambda;
        private readonly ToneSource source;

        public Tone(string toneExpression)
        {
            expression = toneExpression;
            source = ToneSource.FromExpression;
        }

        public Tone(Func<double, double> lambdaExpression)
        {
            lambda = lambdaExpression;
            source = ToneSource.FromLambda;
        }
    }

    public enum ToneSource
    {
        FromExpression,
        FromLambda
    }
}
