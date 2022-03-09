using AutofacPropertyInjection.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutofacPropertyInjection.Controllers
{
    public class TimeController : Controller
    {
        //Method Injection
        public IActionResult Index([FromServices] ITimeService timeService)
        {
           return Ok(timeService.GetDateTime());
        }
    }
}
