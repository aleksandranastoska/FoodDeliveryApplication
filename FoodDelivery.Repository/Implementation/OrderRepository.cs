using FoodDelivery.Domain.Domain;
using FoodDelivery.Repository.Interface;
using Microsoft.EntityFrameworkCore;

namespace FoodDelivery.Repository.Implementation
{
    public class OrderRepository : IOrderRepository
    {
        
        private readonly ApplicationDbContext _context;
        private DbSet<Order> entities;

        public OrderRepository(ApplicationDbContext context)
        {
            _context = context;
            entities = context.Set<Order>();
        }

        public List<Order> GetAll()
        {
            return entities
                .Include(o=>o.FoodsInOrder)
                .Include(o=>o.Owner)
                .Include("FoodsInOrder.Food")
                .ToList();
        }

        public Order GetDetailsForOrder(BaseEntity? id)
        {
            return entities
                .Include(o => o.FoodsInOrder)
                .Include(o => o.Owner)
                .Include("FoodsInOrder.Food")
                .SingleOrDefaultAsync(z => z.Id == id.Id).Result;
        }

        public void Insert(Order order)
        {
            CheckIfEntityIsNull(order);
        }

        private void CheckIfEntityIsNull(Order entity)
        {
            if (entity == null) 
            { 
                throw new ArgumentNullException("entity"); 
            }
        }
    }
}
