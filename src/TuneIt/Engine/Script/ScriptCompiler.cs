using System;
using System.CodeDom.Compiler;

using Microsoft.CSharp;

using TuneItDynamicBase;

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
            var codeProvider = new CSharpCodeProvider();
            var compilerResults =
                codeProvider.CompileAssemblyFromSource(
                    new CompilerParameters(new[] {"TuneItDynamicBase.dll"}) {GenerateInMemory = true},
                    @"
using System;
using TuneItDynamicBase;

public class DynamicCompiledScript : DynamicCompiledScriptBase
{
    public override Func<double, double> Evaluator
    {
        get
        {
            return delegate(double time)
                   {"
                        + script + @"
                   };
        }
    }
}
");
            if (compilerResults.Errors.HasErrors)
            {
                return null;
            }
            var dynamicScriptInstance = (IDynamicScript) compilerResults.CompiledAssembly.CreateInstance("DynamicCompiledScript");
            if (dynamicScriptInstance == null)
            {
                return null;
            }
            return dynamicScriptInstance.Evaluator;
        }
    }
}
