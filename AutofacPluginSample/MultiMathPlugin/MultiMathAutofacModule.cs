using Autofac;
using System;
using System.Collections.Generic;
using System.Text;

namespace MultiMathPlugin
{
    public class MultiMathAutofacModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<MultiMathOperation>().AsImplementedInterfaces();
        }
    }
}
