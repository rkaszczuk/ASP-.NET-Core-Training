using IoCAutofacInterfacesSample.SampleInterfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace IoCAutofacConsoleSample.SampleImp
{
    class Foo : IFoo
    {
        public string GetHello()
        {
            return "Hello from Foo!";
        }
    }
}
