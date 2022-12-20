using System.Linq;
using Microsoft.AspNetCore.Mvc;
using SportStore.Models;
using SportStore.Models.ViewModels;

namespace SportStore.Controllers
{
	public class HomeController : Controller
	{
		public HomeController(IStoreRepository repository)
		{
			this.repository = repository;
		}
		public int PageSize = 4;
		private IStoreRepository repository;
		public ViewResult Index(string category, int productPage = 1) => View(new ProductsListViewModel
		{
			Products = repository.Products
			.Where(p => category == null || p.Category == category)
			.Skip((productPage - 1) * PageSize)
			.Take(PageSize),
			PagingInfo = new PagingInfo
			{
				CurrentPage = productPage,
				ItemsPerPage = PageSize,
				TotalItems = category == null ? repository.Products.Count() : repository.Products.Where(e => e.Category == category).Count()
			}
		});

	}
}

