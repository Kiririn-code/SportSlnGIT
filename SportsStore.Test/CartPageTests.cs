using System.Linq;
using System.Text;
using System.Text.Json;
using Microsoft.AspNetCore.Routing;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Moq;
using SportStore.Models;
using SportStore.Pages;
using Xunit;

namespace SportsStore.Test
{
	public class CartPageTests
	{
		[Fact]
		public void CanLoadCart()
        {
			Product p1 = new Product { ProductID = 1, Name = "P1" };
			Product p2 = new Product { ProductID = 2, Name = "P2" };

			Mock<IStoreRepository> mockRepo = new Mock<IStoreRepository>();
			mockRepo.Setup(ctx => ctx.Products).Returns((
				new Product[] { p1, p2 }).AsQueryable<Product>());

			Cart cart = new Cart();
			cart.AddItem(p1, 2);
			cart.AddItem(p2, 1);

			CartModel cartModel = new CartModel(mockRepo.Object, cart);
			cartModel.OnGet("myUrl");
			Assert.Equal(2, cartModel.Cart.Lines.Count());
			Assert.Equal("myUrl", cartModel.ReturnUrl);
        }

		 [Fact]
		 public void CanUpdateCart()
        {
			Mock<IStoreRepository> mockRepos = new Mock<IStoreRepository>();
			Cart testCart = new Cart();

			mockRepos.Setup(ctx => ctx.Products).Returns((new Product[]
			{
				new Product{ProductID =1,Name="p1"}
			}).AsQueryable<Product>());

			CartModel cartModel = new CartModel(mockRepos.Object, testCart);

			cartModel.OnPost(1, "myUrl");

			Assert.Equal("p1", testCart.Lines.First().Product.Name);
			Assert.Equal(1, testCart.Lines.First().Quantity);
				
        }
	}
}

