using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Nortwind.Repository;

namespace AspNetCoreWebAPI.Controllers
{
   [Produces("application/json")]
    [Route("api/Orders")]
    public class OrdersController : Controller
   {
      private OrdersRepository _orders;
      public IActionResult GetOrders()
       {

          return Ok();
       }
    }
}