using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace Nortwind.Repository
{
  public interface IOrdersRepository
   {
      IEnumerable<Order> GetOrders();
   }
}
