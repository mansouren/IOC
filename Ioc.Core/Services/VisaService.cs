using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ioc.Core.Services
{
    public class VisaService : ICreditCard
    {
        public string Charge()
        {
            return "Visa Card has been charged!";
        }
    }
}
