using PluginTemplate;
using System;

namespace SumMathPlugin
{
    public class DoubleSumMathOperation : IMathOperation<double>
    {
        public double Operation(double arg1, double arg2)
        {
            return arg1 + arg2;
        }
    }
}
