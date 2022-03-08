using Ioc.Core.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ioc.Core.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShopperController : ControllerBase
    {
        private readonly ICreditCard creditCard;

        public ShopperController(ICreditCard creditCard)
        {
            this.creditCard = creditCard;
        }

        public ActionResult<string> Get()
        {
           return Ok(creditCard.Charge());
        }
    }
}
