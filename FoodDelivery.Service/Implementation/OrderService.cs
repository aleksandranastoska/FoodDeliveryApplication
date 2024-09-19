using FoodDelivery.Domain.Domain;
using FoodDelivery.Repository.Interface;
using FoodDelivery.Service.Interface;

namespace FoodDelivery.Service.Implementation
{
    public class OrderService : IOrderService
    {
        private readonly IOrderRepository _orderRepository;

        public OrderService(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }

        public void CreateNewOrder(Order o)
        {
            _orderRepository.Insert(o);
        }

        public void DeleteExistingOrder(Guid? id)
        {
            var order = _orderRepository.GetDetailsForOrder(id);
            _orderRepository.Delete(order);
        }

        public List<Order> GetAll()
        {
            return _orderRepository.GetAll().ToList();
        }

        public Order GetDetailsForOrder(Guid? id)
        {
            return _orderRepository.GetDetailsForOrder(id);
        }

        public void UpdateExistingOrder(Order o)
        {
            _orderRepository.Update(o);
        }
    }
}
