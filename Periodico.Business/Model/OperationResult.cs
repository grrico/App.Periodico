using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Periodico.Business.Model
{
    public class OperationResult<T>
    {
        public T Result { get; private set; }

        public bool Success { get; private set; }

        public Exception Error { get; private set; }

        public string Caller { get; set; }

        public static OperationResult<T> SuccessResponse(T result, [CallerMemberName] string memberName = "")
        {
#if DEBUG
            Trace.WriteLine(memberName + "- OK", "SuccessResponse");
#endif
            return new OperationResult<T>
            {
                Error = null,
                Result = result,
                Success = true,
                Caller = memberName
            };
        }

        public static OperationResult<T> ErrorResponse(Exception error, T result, [CallerMemberName] string memberName = "")
        {
            Trace.WriteLine(memberName + " .Error: " + error, "ErrorResponse");
            return new OperationResult<T>
            {
                Error = error,
                Result = result,
                Success = false,
                Caller = memberName
            };
        }

        public static OperationResult<T> ErrorResponse(Exception error, [CallerMemberName] string memberName = "")
        {
            Trace.WriteLine(memberName + " .Error: " + error, "ErrorResponse");
            return new OperationResult<T>
            {
                Error = error,
                Success = false,
                Caller = memberName
            };
        }
    }
}
