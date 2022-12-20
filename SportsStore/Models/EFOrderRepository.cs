using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace SportStore.Models
{
	public class EFOrderRepository : IOrderRepository
	{
		private StoreDbContext context;
		public EFOrderRepository(StoreDbContext context)
		{
			this.context = context;
		}

		public IQueryable<Order> Orders => context.Orders
				.Include(ctx => ctx.Lines)
				.ThenInclude(ctx => ctx.Product);

        public void SaveOrder(Order order)
        {
			context.AttachRange(order.Lines.Select(ctx => ctx.Product));
            if (order.OrderID == 0)
            {
				context.Orders.Add(order);
            }
			context.SaveChanges();
        }
    }
}

