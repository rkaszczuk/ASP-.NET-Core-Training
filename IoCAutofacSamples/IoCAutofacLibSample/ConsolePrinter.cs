using IoCAutofacInterfacesSample.SampleInterfaces;
using System;

namespace IoCAutofacLibSample
{
    public class ConsolePrinter : IPrinter
    {
        private IFoo foo;
        public ConsolePrinter(IFoo foo)
        {
            this.foo = foo;
        }
        public void Print()
        {
            Console.WriteLine(foo.GetHello());
        }
    }
}
