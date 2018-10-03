using IoCAutofacInterfacesSample.SampleInterfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace IoCAutofacConsoleSample.SampleImp
{
    class Counter : ICounter
    {
        private int value { get; set; } = 0;
        public int GetNext()
        {
            return ++value;
        }
    }
}
