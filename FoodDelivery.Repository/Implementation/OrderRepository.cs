﻿using FoodDelivery.Domain.Domain;
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

        public void Delete(Order order)
        {
            CheckIfEntityIsNull(order);
            entities.Remove(order);
            _context.SaveChanges();
        }

        public List<Order> GetAll()
        {
            return entities.Include(o => o.FoodsInOrder)
        .ThenInclude(fio => fio.Food)
            .ThenInclude(f => f.Restaurant) 
    .Include(o => o.Owner)
    .Include(o => o.Address)
    .ToList();
        }

        public List<Order> GetAllOrdersForUser(string? userId)
        {
            if (string.IsNullOrEmpty(userId))
            {
                throw new ArgumentNullException(nameof(userId));
            }

            var entities = _context.Orders.AsQueryable();

            if (entities == null)
            {
                return new List<Order>();
            }

            return entities.Where(order => order.UserId == userId).ToList();
        }

        public Order GetDetailsForOrder(BaseEntity? id)
        {
            return entities.Include(o => o.Address)
                .Include(o => o.FoodsInOrder)
                .Include("FoodsInOrder.Food")
                .Include(o => o.Owner)
                .SingleOrDefaultAsync(z => z.Id == id.Id).Result;
        }

        public Order GetDetailsForOrder(Guid? id)
        {
            return entities.Include(o => o.Address)
                .Include(o => o.FoodsInOrder)
                .Include(o => o.Owner)
                .Include("FoodsInOrder.Food")
                .SingleOrDefaultAsync(z => z.Id == id).Result;
        }

        public void Insert(Order order)
        {
            CheckIfEntityIsNull(order);
            entities.Add(order);
            _context.SaveChanges();
        }

        public void Update(Order order)
        {
            CheckIfEntityIsNull(order);
            entities.Update(order);
            _context.SaveChanges();
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
