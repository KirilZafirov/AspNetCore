using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreWebApiNet.Models;

namespace CoreWebApiNet.Repository
{
    public interface IOrdersRepository
    {
       IEnumerable<Orders> GetOrders();
   }
}
