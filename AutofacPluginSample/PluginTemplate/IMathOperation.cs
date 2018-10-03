using System;
using System.Collections.Generic;
using System.Text;

namespace PluginTemplate
{
    public interface IMathOperation<T>
    {
        T Operation(T arg1, T arg2);
    }
}
