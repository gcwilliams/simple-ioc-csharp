using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOC.Builder
{
    /// <summary>
    /// The binding implementation base class
    /// </summary>
    internal abstract class Binding
    {
        /// <summary>
        /// Gets the interface type
        /// </summary>
        public Type InterfaceType { get; protected set; }

        /// <summary>
        /// Gets the implementation type
        /// </summary>
        public Type ImplementationType { get; protected set; }
    }

    /// <summary>
    /// The binding implementation
    /// </summary>
    internal class Binding<TInter> : Binding, IBinding<TInter>
    {
        /// <summary>
        /// Default constructor
        /// </summary>
        internal Binding()
        {
            InterfaceType = typeof(TInter);
        }

        /// <summary>
        /// Binds the type to the interface
        /// </summary>
        public void To<TImpl>() where TImpl : TInter
        {
            ImplementationType = typeof(TImpl);
        }
    }
}
