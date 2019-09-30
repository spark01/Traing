using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using MyWindowsFormsApp.Repository;

namespace MyWindowsFormsApp.BLL
{
    class OrderManager
    {
        OrderRepository _orderRepository = new OrderRepository();
        public bool Add(int quantity)
        {
            return _orderRepository.Add(quantity);
        }
        public bool Delete(int id)
        {
            return _orderRepository.Delete(id);
        }

        public DataTable Display()
        {
            return _orderRepository.Display();
        }

        public bool Update( int quantity, int id)
        {
            return _orderRepository.Update(quantity, id);
        }

        public DataTable Search(int quantity)
        {
            return _orderRepository.Search(quantity);
        }
    }
}
