using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace Nortwind.Repository
{
  public class OrdersRepository
   {
      private NorthwindModelDbContext context;

      public IEnumerable<Order> GetOrders()
      {
         return context.Orders;
      }
   }
}
