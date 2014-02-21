using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOCTest
{
    public class Service : IService
    {
        public Service(IValidator validator, IDao dao)
        {
        }
    }
}
