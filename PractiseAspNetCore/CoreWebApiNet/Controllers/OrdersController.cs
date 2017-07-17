using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreWebApiNet.Models;
using CoreWebApiNet.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
namespace CoreWebApiNet.Controllers
{
    //[Produces("application/json")]
    [Route("api/Orders")]
    public class OrdersController : Controller
    {
      // private IOrdersRepository _orders;
       private readonly NORTHWNDContext _context;

       public OrdersController(NORTHWNDContext context)
       {
          _context = context;
       }

       // GET: api/Products
       [HttpGet]
       public IEnumerable<Orders> GetOrders()
       {
          return _context.Orders;
       }
   }
}