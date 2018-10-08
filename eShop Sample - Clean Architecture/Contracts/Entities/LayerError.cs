using System;
using System.Collections.Generic;
using System.Text;

namespace Contracts.Entities
{
    public enum LayerErrorType { Critical, Error, Warning, Msg}
    public class LayerError
    {
        public Exception Exception { get; set; }
        public string Msg { get; set; }
        public LayerErrorType ErrorType { get; set; }
    }
}
