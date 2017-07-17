using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreWebApiNet.Models;

namespace CoreWebApiNet.Repository
{
    public class OrdersRepository
   {
      private NORTHWNDContext _context;

      public OrdersRepository(NORTHWNDContext context)
      {
         _context = context;
      }
      public IEnumerable<Orders> GetOrders()
      {
         return _context.Orders;
      }
   }
}
