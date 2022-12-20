using Microsoft.AspNetCore.Mvc;
using Moq;
using SportStore.Controllers;
using SportStore.Models;
using Xunit;

namespace SportsStore.Test
{
	public class OrderControllerTests
	{
		[Fact]
		public void CannotCHeckoutEmptyCart()
        {
			Mock<IOrderRepository> mock = new Mock<IOrderRepository>();

			Cart cart = new Cart();
			Order order = new Order();
			OrderController orderController = new OrderController(mock.Object, cart);

			ViewResult result = orderController.Checkout(order) as ViewResult;

			mock.Verify(ctx => ctx.SaveOrder(It.IsAny<Order>()), Times.Never);
			Assert.True(string.IsNullOrEmpty(result.ViewName));
			Assert.False(result.ViewData.ModelState.IsValid);
        }

		[Fact]
		public void CannotCheckoutInvalidShippingDetails()
        {
			Mock<IOrderRepository> mock = new Mock<IOrderRepository>();
			Cart cart = new Cart();
			cart.AddItem(new Product(), 1);
			
			OrderController target = new OrderController(mock.Object, cart);
			target.ModelState.AddModelError("error", "error");
			ViewResult result = target.Checkout(new Order()) as ViewResult;

			mock.Verify(ctx => ctx.SaveOrder(It.IsAny<Order>()), Times.Never);
			Assert.True(string.IsNullOrEmpty(result.ViewName));
			Assert.False(result.ViewData.ModelState.IsValid);
        }

		[Fact]
		public void CanCheckoutAndSubmitOrder()
        {
			Mock<IOrderRepository> mock = new Mock<IOrderRepository>();
			Cart cart = new Cart();
			cart.AddItem(new Product(), 1);

			OrderController target = new OrderController(mock.Object, cart);
			RedirectToPageResult result = target.Checkout(new Order()) as RedirectToPageResult;

			mock.Verify(ctx => ctx.SaveOrder(It.IsAny<Order>()), Times.Once);

			Assert.Equal("/Completed", result.PageName);
        }
	}
}

