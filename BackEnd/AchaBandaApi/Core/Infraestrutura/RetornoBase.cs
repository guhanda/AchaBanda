using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AchaBandaApi.Core.Infraestrutura
{
    public class RetornoBase
    {
        public bool Success { get; set; }

        public string Message { get; set; }
    }

    public class RetornoBase<T> : RetornoBase
    {
        public T Value { get; set; }
    }
}