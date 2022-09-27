using System;
using System.Collections.Generic;
using System.Text;
using Business.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class OrderManager :IOrderService
    {
        public List<Order> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
