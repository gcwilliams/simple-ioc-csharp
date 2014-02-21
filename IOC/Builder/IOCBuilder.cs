using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOC.Builder
{
    /// <summary>
    /// The inversion of control builder
    /// </summary>
    public class IOCBuilder
    {
        private readonly IList<Binding> bindings = new List<Binding>();

        private IOCBuilder() { }

        /// <summary>
        /// Creates a new inversion of control builder
        /// </summary>
        /// <returns>The inversion of control</returns>
        public static IOCBuilder NewInstance()
        {
            return new IOCBuilder();
        }

        /// <summary>
        /// Binds an interface to an implementation
        /// </summary>
        /// <returns>The binding for the specified  interface</returns>
        public IBinding<T> Bind<T>()
        {
            Binding<T> binding = new Binding<T>();
            bindings.Add(binding);
            return binding;
        }

        /// <summary>
        /// Build the inversion of control
        /// </summary>
        /// <returns>The inversion of control</returns>
        public IIOC Build()
        {
            return new IOC(bindings);
        }
    }
}
