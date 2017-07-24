using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Northwind.Entities;

namespace Nortwind.Repository
{
  public interface IOrdersRepository
   {
      IEnumerable<Orders> GetOrders();
   }
}
