using FoodDelivery.Domain.Domain;

namespace FoodDelivery.Service.Interface
{
    public interface IOrderService
    {
        List<Order> GetAll();
        Order GetDetailsForOrder(Guid? id);
        Order GetDetailsForOrder(BaseEntity? id);
        void CreateNewOrder(Order o);
        void UpdateExistingOrder(Order o);
        void DeleteExistingOrder(Guid? id);
    }
}
