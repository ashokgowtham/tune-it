using System;

using ciloci.Flee;

namespace TuneIt.Engine.Script
{
    public class ScriptCompiler
    {
        private readonly string script;

        public ScriptCompiler(string script)
        {
            this.script = script;
        }
        /// <summary>
        /// Compiles the srcipt and returns an evaluator (a delegate) 
        /// which takes in time and returns audioFrame values
        /// </summary>
        /// <returns>A delegate of type Func&lt;double,double&gt;</returns>
        public Func<double, double> Compile()
        {
            var compileContext = new CompileContext();
            var expression = new Expression(script, compileContext);
            return time =>
                   {
                       compileContext.Time = time;
                       var evaluator = (ExpressionEvaluator<double>) expression.Evaluator;
                       return evaluator();
                   };
        }
    }
}
