using IOC.Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace IOC
{
    /// <summary>
    /// The IOC implementation
    /// </summary>
    internal class IOC : IIOC
    {
        private readonly IEnumerable<Binding> bindings;

        /// <summary>
        /// Default constructor
        /// </summary>
        /// <param name="bindings">The binding</param>
        internal IOC(IEnumerable<Binding> bindings)
        {
            this.bindings = bindings;
        }

        /// <summary>
        /// Resolves the type specified based on the bindings
        /// </summary>
        /// <returns>The type specified</returns>
        public T Resolve<T>() where T : class
        {
            return (T)Resolve(typeof(T));
        }

        /// <summary>
        /// Resolves the type specified based on the bindings
        /// </summary>
        /// <param name="type">The type to resolve</param>
        /// <returns>The type specified</returns>
        private object Resolve(Type type)
        {
            Binding binding = bindings.FirstOrDefault(b => b.InterfaceType == type);

            if (binding == null)
            {
                throw new BindingException("Could not find binding for {0}", type);
            }

            ConstructorInfo constructor = binding.ImplementationType.GetConstructors().First();
            object[] dependencies = constructor.GetParameters().Select(d => Resolve(d.ParameterType)).ToArray();
            return constructor.Invoke(dependencies);
        }
    }
}
