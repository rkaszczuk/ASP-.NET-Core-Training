using IoCAutofacInterfacesSample.SampleInterfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace IoCAutofacConsoleSample.SampleImp
{
    class Foo2 : IFoo
    {
        public string Name { get; set; }
        public Foo2(string name)
        {
            Name = name;
        }
        public string GetHello()
        {
            return $"Hello {Name} from Foo2!";
        }
    }
}
