using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOC.Builder
{
    /// <summary>
    /// The binding, specified the type to bind to an interface
    /// </summary>
    public interface IBinding<TInter>
    {
        /// <summary>
        /// Binds the type to the interface
        /// </summary>
        void To<TImpl>() where TImpl : TInter;
    }
}
