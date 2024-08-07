using FoodDelivery.Domain.Domain;
namespace FoodDelivery.Repository.Interface
{
    public interface IOrderRepository
    {
        List<Order> GetAll();
        Order GetDetailsForOrder(BaseEntity? id);
        void Insert(Order order);
    }
}
