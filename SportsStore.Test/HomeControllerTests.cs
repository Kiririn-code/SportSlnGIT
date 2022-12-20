using Microsoft.AspNetCore.Mvc;
using Moq;
using System.Linq;
using System.Collections.Generic;
using SportStore.Controllers;
using SportStore.Models;
using Xunit;
using SportStore.Models.ViewModels;
using System;

namespace SportsStore.Test
{
	public class HomeControllerTests
	{
		[Fact]
		public void CanUseRepository()
		{
			Mock<IStoreRepository> mock = new Mock<IStoreRepository>();
			mock.Setup(ctx => ctx.Products).Returns((new Product[]
			{
				new Product{ProductID =1, Name = "Product1" },
				new Product{ProductID = 2, Name = "Product2"}
			}).AsQueryable<Product>());

			HomeController controller = new HomeController(mock.Object);
			ProductsListViewModel result = (controller.Index(null) as ViewResult).ViewData.Model as ProductsListViewModel;
			Product[] prodArray = result.Products.ToArray();
			Assert.True(prodArray.Length == 2);
			Assert.Equal("Product1", prodArray[0].Name);
			Assert.Equal("Product2", prodArray[1].Name);
		}
		[Fact]
		public void CanPaginate()
		{
			Mock<IStoreRepository> mock = new Mock<IStoreRepository>();
			mock.Setup(ctx => ctx.Products).Returns((new Product[]
			{
				new Product{ProductID = 1, Name ="Product1"},
				new Product{ProductID = 2, Name ="Product2"},
				new Product{ProductID = 3, Name ="Product3"},
				new Product{ProductID = 4, Name ="Product4"},
				new Product{ProductID = 5, Name ="Product5"}
			}).AsQueryable<Product>());

			HomeController controller = new HomeController(mock.Object);
			controller.PageSize = 3;
			ProductsListViewModel result =
				(controller.Index(null,2) as ViewResult).ViewData.Model as ProductsListViewModel;
			Product[] prodArray = result.Products.ToArray();
			Assert.True(prodArray.Length == 2);
			Assert.Equal("Product4", prodArray[0].Name);
			Assert.Equal("Product5", prodArray[1].Name);

		}

		[Fact]
		public void CanSendPaginationViewModel()
		{
			Mock<IStoreRepository> mock = new Mock<IStoreRepository>();
			mock.Setup(ctx => ctx.Products).Returns((new Product[]
			{
				new Product{ProductID = 1, Name ="Product1"},
				new Product{ProductID = 2, Name ="Product2"},
				new Product{ProductID = 3, Name ="Product3"},
				new Product{ProductID = 4, Name ="Product4"},
				new Product{ProductID = 5, Name ="Product5"}
			}).AsQueryable<Product>());

			HomeController controller = new HomeController(mock.Object) { PageSize = 3 };
			ProductsListViewModel result =
				(controller.Index(null,2) as ViewResult).ViewData.Model as ProductsListViewModel;

			PagingInfo pageInfo = result.PagingInfo;
			Assert.Equal(2, pageInfo.CurrentPage);
			Assert.Equal(3, pageInfo.ItemsPerPage);
			Assert.Equal(5, pageInfo.TotalItems);
			Assert.Equal(2, pageInfo.TotalPages);
		}
		[Fact]
		public void CanFilterProducts()
        {
			Mock<IStoreRepository> mock = new Mock<IStoreRepository>();
			mock.Setup(ctx => ctx.Products).Returns((new Product[]
			{
				new Product{ProductID = 1,Name = "P1", Category ="Cat1"},
				new Product{ProductID = 2,Name = "P2", Category ="Cat2"},
				new Product{ProductID = 3,Name = "P3", Category ="Cat1"},
				new Product{ProductID = 4,Name = "P4", Category ="Cat2"},
				new Product{ProductID = 5,Name = "P5", Category ="Cat3"}
			}).AsQueryable<Product>());

			HomeController homeController = new HomeController(mock.Object);
			homeController.PageSize = 3;
			Product[] result = ((homeController.Index("Cat2") as ViewResult).ViewData.Model as ProductsListViewModel).Products.ToArray();

			Assert.Equal(2, result.Length);
			Assert.True(result[0].Name == "P2" && result[0].Category == "Cat2");
			Assert.True(result[1].Name == "P4" && result[1].Category == "Cat2");
		}

		[Fact]
		public void GenerateCategorySpecificProductCount()
        {
			Mock<IStoreRepository> mock = new Mock<IStoreRepository>();

			mock.Setup(ctx => ctx.Products).Returns((new Product[]
			{
				new Product{ProductID = 1,Name = "P1", Category ="Cat1"},
				new Product{ProductID = 2,Name = "P2", Category ="Cat2"},
				new Product{ProductID = 3,Name = "P3", Category ="Cat1"},
				new Product{ProductID = 4,Name = "P4", Category ="Cat2"},
				new Product{ProductID = 5,Name = "P5", Category ="Cat3"}
			}).AsQueryable<Product>());

			HomeController target = new HomeController(mock.Object);

			target.PageSize = 3;
			Func<ViewResult, ProductsListViewModel> GetModel = result => result?.ViewData?.Model as ProductsListViewModel;

			int? res1 = GetModel(target.Index("Cat1"))?.PagingInfo.TotalItems;
			int? res2 = GetModel(target.Index("Cat2"))?.PagingInfo.TotalItems;
			int? res3 = GetModel(target.Index("Cat3"))?.PagingInfo.TotalItems;
			int? resAll = GetModel(target.Index(null))?.PagingInfo.TotalItems;

			Assert.Equal(2, res1);
			Assert.Equal(2, res2);
			Assert.Equal(1, res3);
			Assert.Equal(5, resAll);
		}
	}
}
