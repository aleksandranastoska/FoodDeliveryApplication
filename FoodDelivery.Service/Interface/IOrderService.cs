using FoodDelivery.Domain.Domain;

namespace FoodDelivery.Service.Interface
{
    public interface IOrderService
    {
        List<Order> GetAll();
        Order GetDetailsForOrder(BaseEntity id);
    }
}
