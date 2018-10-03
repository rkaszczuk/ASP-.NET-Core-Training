using PluginTemplate;
using System;

namespace MultiMathPlugin
{
    public class MultiMathOperation : IMathOperation<double>
    {
        public double Operation(double arg1, double arg2)
        {
            return arg1 * arg2;
        }
    }
}
