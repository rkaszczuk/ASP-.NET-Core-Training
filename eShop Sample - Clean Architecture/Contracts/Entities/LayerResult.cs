using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Contracts.Entities
{
    public class LayerResult
    {
        public LayerResult()
        {
            Errors = new List<LayerError>();
        }
        public void AddError(Exception exception, string msg, LayerErrorType errorType)
        {
            var error = new LayerError()
            {
                Exception = exception,
                Msg = msg,
                ErrorType = errorType
            };
            Errors.Add(error);
        }
        public bool IsSuccess
        {
            get
            {
                return !Errors.Any(x => x.ErrorType == LayerErrorType.Critical || x.ErrorType == LayerErrorType.Error);
            }
        }
        public List<LayerError> Errors { get; set; }
    }
    public class LayerResult<T> : LayerResult
    {
        public T Result { get; set; }
        public LayerResult(T result)
        {
            Result = result;
        }
    }
}
