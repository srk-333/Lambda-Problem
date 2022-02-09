using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaProblem
{
    public class LambdaException : Exception
    {
        ExceptionType type;
        public enum ExceptionType
        {
            Exception
        }
        public LambdaException(ExceptionType type, string message) : base(message)
        {
            this.type = type;
        }
    }
}