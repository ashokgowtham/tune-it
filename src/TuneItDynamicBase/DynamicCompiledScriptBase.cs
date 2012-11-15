using System;

namespace TuneItDynamicBase
{
    public abstract class DynamicCompiledScriptBase : IDynamicScript
    {
        protected const double PI = 3.1415926535897931;
        protected const double E = 2.7182818284590451;

        #region IDynamicScript Members

        public abstract Func<double, double> Evaluator { get; }

        #endregion

        protected double sin(double d)
        {
            return Math.Sin(d);
        }

        protected double Acos(double d)
        {
            return Math.Acos(d);
        }

        protected double Asin(double d)
        {
            return Math.Asin(d);
        }

        protected double Atan(double d)
        {
            return Math.Atan(d);
        }

        protected double Atan2(double y, double x)
        {
            return Math.Atan2(y, x);
        }

        protected double Ceiling(double a)
        {
            return Math.Ceiling(a);
        }

        protected double Cos(double d)
        {
            return Math.Cos(d);
        }

        protected double Cosh(double value)
        {
            return Math.Cosh(value);
        }

        protected double Floor(double d)
        {
            return Math.Floor(d);
        }

        protected double Sin(double a)
        {
            return Math.Sin(a);
        }

        protected double Tan(double a)
        {
            return Math.Tan(a);
        }

        protected double Sinh(double value)
        {
            return Math.Sinh(value);
        }

        protected double Tanh(double value)
        {
            return Math.Tanh(value);
        }

        protected double Round(double a)
        {
            return Math.Round(a);
        }

        protected double Round(double value, int digits)
        {
            return Math.Round(value, digits);
        }

        protected double Truncate(double d)
        {
            return Math.Truncate(d);
        }

        protected double Sqrt(double d)
        {
            return Math.Sqrt(d);
        }

        protected double Log(double d)
        {
            return Math.Log(d);
        }

        protected double Log10(double d)
        {
            return Math.Log10(d);
        }

        protected double Exp(double d)
        {
            return Math.Exp(d);
        }

        protected double Pow(double x, double y)
        {
            return Math.Pow(x, y);
        }

        protected double IEEERemainder(double x, double y)
        {
            return Math.IEEERemainder(x, y);
        }

        protected double Abs(double value)
        {
            return Math.Abs(value);
        }

        protected double Max(double val1, double val2)
        {
            return Math.Max(val1, val2);
        }

        protected double Min(double val1, double val2)
        {
            return Math.Min(val1, val2);
        }

        protected double Log(double a, double newBase)
        {
            return Math.Log(a, newBase);
        }

        protected double Sign(double value)
        {
            return Math.Sign(value);
        }
    }
}
