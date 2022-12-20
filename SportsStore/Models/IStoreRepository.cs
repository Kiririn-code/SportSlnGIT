using System.Linq;
namespace SportStore.Models
{
	public interface IStoreRepository
	{
		IQueryable<Product> Products { get; }
		void SaveProduct(Product product);
		void DeleteProduct(Product product);
		void CreateProduct(Product product);
	}
}

