using System;
using System.Collections.Generic;
using System.Text;

namespace Syntrol.Exceptions
{
    /// <summary>
    /// Exception for checking current connection status
    /// </summary>
    public class ComException : Exception
    {
        /// <summary>
        /// Base exception
        /// </summary>
        public ComException()
        {

        }

        /// <summary>
        /// Com Exception that contains a reference to the frame
        /// </summary>
        /// <param name="message"></param>
        /// <param name="inner"></param>
        public ComException(string message, Exception inner) : base (message, inner)
        {

        }
    }
}
