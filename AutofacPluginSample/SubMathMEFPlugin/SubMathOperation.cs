using PluginTemplate;
using System;
using System.Composition;

namespace SubMathMEFPlugin
{
    [Export(typeof(IMathOperation<decimal>))]
    public class SubMathOperation : IMathOperation<decimal>
    {
        public decimal Operation(decimal arg1, decimal arg2)
        {
            return arg1 - arg2;
        }
    }
}
