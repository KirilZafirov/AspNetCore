using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Northwind.Entities;
using Nortwind.Repository;

namespace CoreWebApiNet.Controllers
{
    //[Produces("application/json")]
    [Route("api/Orders")]
    public class OrdersController : Controller
    {
       private IOrdersRepository _orders;
     


       public OrdersController(IOrdersRepository orders)
       {
          _orders = orders;
       }
      
       // GET: api/Products
       [HttpGet]
       public IEnumerable<Orders> GetOrders()
       {
         return _orders.GetOrders();
       }

      
   }
}