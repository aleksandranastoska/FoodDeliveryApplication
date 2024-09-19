using FoodDelivery.Domain.Domain;
namespace FoodDelivery.Repository.Interface
{
    public interface IOrderRepository
    {
        List<Order> GetAll();
        Order GetDetailsForOrder(Guid? id);
        void Insert(Order order);
        void Update(Order order);
        void Delete(Order order);
    }
}
