using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace Nortwind.Repository
{
  public class OrdersRepository : IOrdersRepository
   {
      private NorthwindModelDbContext _context;

      public OrdersRepository(NorthwindModelDbContext context)
      {
         _context = context;
      }
      public IEnumerable<Order> GetOrders()
      {
         return _context.Orders;
      }
   }
}
