using System.Linq;
using Xunit;
using Moq;
using SportStore.Models;
using SportStore.Components;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Components;
using System.Collections.Generic;

namespace SportsStore.Test
{
	public class NavigationMenuViewComponentTests
	{
		[Fact]
		public void CanSelectCategories()
        {
			Mock<IStoreRepository> mock = new Mock<IStoreRepository>();
			mock.Setup(m => m.Products).Returns((new Product[]
			{
				new Product{ProductID =1,Name="P1",Category="Apples"},
				new Product{ProductID =2,Name="P2",Category="Apples"},
				new Product{ProductID =3,Name="P3",Category="Plums"},
				new Product{ProductID =4,Name="P4",Category="Oranges"},
			}).AsQueryable<Product>());

			NavigationMenuViewComponent target = new NavigationMenuViewComponent(mock.Object);
			string[] results = ((IEnumerable<string>)(target.Invoke() as ViewComponentResult).ViewData.Model).ToArray();

			Assert.True(Enumerable.SequenceEqual(new string[] { "Apples", "Oranges", "Plums" }, results));
        }
	}
}

