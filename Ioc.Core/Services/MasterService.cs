using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ioc.Core.Services
{
    public class MasterService : ICreditCard
    {
        public string Charge()
        {
            return "Master Card has been Charged!";
        }
    }
}
