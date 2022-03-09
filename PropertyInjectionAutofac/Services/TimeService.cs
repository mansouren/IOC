using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ioc.Core.Services
{
    public class TimeService : ITimeService
    {
        public string GetDateTime()
        {
           return DateTime.Now.ToShortDateString();
        }
    }
}
