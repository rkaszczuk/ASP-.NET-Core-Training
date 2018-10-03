using Autofac;
using System;
using System.Collections.Generic;
using System.Text;

namespace SumMathPlugin
{
    public class SumMathAutofacModule : Module 
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<IntSumMathOperation>().AsImplementedInterfaces();
            builder.RegisterType<DoubleSumMathOperation>().AsImplementedInterfaces();
        }
    }
}
