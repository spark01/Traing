 
using System.Data;
 
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
