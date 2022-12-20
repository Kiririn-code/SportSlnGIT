using System;
using System.Linq;

namespace SportStore.Models
{
    public class EFStoreRepository : IStoreRepository
    {
        public EFStoreRepository(StoreDbContext ctx)
        {
            context = ctx;
        }

        private StoreDbContext context;
        public IQueryable<Product> Products => context.Products;

        public void SaveProduct(Product product)
        {
            context.SaveChanges();
        }

        public void DeleteProduct(Product product)
        {
            context.Remove(product);
            context.SaveChanges();
        }

        public void CreateProduct(Product product)
        {
            context.Add(product);
            context.SaveChanges();
        }
    }
}

