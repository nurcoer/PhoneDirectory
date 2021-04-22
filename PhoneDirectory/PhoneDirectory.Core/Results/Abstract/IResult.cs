using System;
using System.Collections.Generic;
using System.Text;

namespace PhoneDirectory.Core.Results.Utilities
{
    public interface IResult
    {
        bool Success { get; }
        string Message { get; }
    }
}
