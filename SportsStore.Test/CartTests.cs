using Xunit;
using System.Linq;
using SportStore.Models;

namespace SportsStore.Test
{
	public class CartTests
	{
		[Fact]
		public void CanAddNewLines()
		{
			Product p1 = new Product { ProductID = 1, Name = "P1" };
			Product p2 = new Product { ProductID = 2, Name = "P2" };

			Cart target = new Cart();

			target.AddItem(p1, 1);
			target.AddItem(p2, 1);

			CartLine[] res = target.Lines.ToArray();

			Assert.Equal(2, res.Length);
			Assert.Equal(p1, res[0].Product);
			Assert.Equal(p2, res[1].Product);
        }

		[Fact]
		public void CanAddQuantityForExistingLines()
        {
			Product p1 = new Product { ProductID = 1, Name = "P1" };
			Product p2 = new Product { ProductID = 2, Name = "P2" };

			Cart target = new Cart();

			target.AddItem(p1, 1);
			target.AddItem(p2, 1);
			target.AddItem(p1, 10);

			CartLine[] res = target.Lines.OrderBy(ctx => ctx.Product.ProductID).ToArray();

			Assert.Equal(2, res.Length);
			Assert.Equal(11, res[0].Quantity);
			Assert.Equal(1, res[1].Quantity);
		}

		[Fact]
		public void CanRemoveLine()
		{
			Product p1 = new Product { ProductID = 1, Name = "P1" };
			Product p2 = new Product { ProductID = 2, Name = "P2" };
			Product p3 = new Product { ProductID = 3, Name = "P3" };

			Cart target = new Cart();

			target.AddItem(p1, 1);
			target.AddItem(p2, 3);
			target.AddItem(p3, 5);
			target.AddItem(p2, 1);

			target.RemoveLine(p2);

			Assert.Empty(target.Lines.Where(ctx => ctx.Product == p2));
			Assert.Equal(2, target.Lines.Count());
		}

		[Fact]
		public void CanCalculateCartTotal()
		{
			Product p1 = new Product { ProductID = 1, Price = 100M };
			Product p2 = new Product { ProductID = 2, Price = 50M };

			Cart target = new Cart();

			target.AddItem(p1, 1);
			target.AddItem(p2, 1);
			target.AddItem(p1, 3);

			decimal result = target.ComputeTotalValue();

			Assert.Equal(450M, result);
		}

		[Fact]
		public void CanClearContents()
		{
			Product p1 = new Product { ProductID = 1, Name = "P1" };
			Product p2 = new Product { ProductID = 2, Name = "P2" };

			Cart target = new Cart();

			target.AddItem(p1, 1);
			target.AddItem(p2, 1);
			target.AddItem(p1, 10);

			target.Clear();

			Assert.Empty(target.Lines);
		}
	}
}

