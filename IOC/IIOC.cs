using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOC
{
    /// <summary>
    /// The inversion of control container
    /// </summary>
    public interface IIOC
    {
        /// <summary>
        /// Resolves the type specified based on the bindings
        /// </summary>
        /// <returns>The type specified</returns>
        T Resolve<T>() where T : class;
    }
}
