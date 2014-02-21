using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOC
{
    /// <summary>
    /// The binding exception
    /// </summary>
    public class BindingException : Exception
    {
        /// <summary>
        /// Default constructor
        /// </summary>
        /// <param name="message">The message</param>
        public BindingException(string message) : base(message)
        {
        }

        /// <summary>
        /// Constructor taking a message and the values to format the message with
        /// </summary>
        /// <param name="message">The message</param>
        /// <param name="values">The values for format the message with</param>
        public BindingException(string message, params object[] values) : this(string.Format(message, values))
        {
        }
    }
}
