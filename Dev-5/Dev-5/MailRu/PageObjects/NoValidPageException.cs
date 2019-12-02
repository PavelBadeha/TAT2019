using System;

namespace Dev_5
{
    /// <summary>
    /// Class of no valid exception
    /// </summary>
    class NoValidPageException : Exception
    {
        public NoValidPageException() : base() { }

        public NoValidPageException(string message) : base(message) { }
        public override string Message => "This is not correct page";
    }
}
