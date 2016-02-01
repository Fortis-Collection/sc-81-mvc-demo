using Demo.Fruit;
using Demo.Website.ViewModels.Fruit;
using System;
using System.Linq;
using System.Web.Mvc;

namespace Demo.Website.Controllers
{
    public class FruitController : Controller
    {
		protected readonly IFruitsFactory FruitsFactory;
		protected readonly IFruitListViewModelFactory FruitListViewModelFactory;

		public FruitController(
			IFruitsFactory fruitsFactory,
			IFruitListViewModelFactory fruitListViewModelFactory)
		{
			FruitsFactory = fruitsFactory;
			FruitListViewModelFactory = fruitListViewModelFactory;
		}

		public ActionResult AllFruit()
		{
			var viewModel = FruitListViewModelFactory.Create(FruitsFactory.Create());

			return View(viewModel);
		}

		public ActionResult TopFruit()
		{
			var r = new Random();
			var viewModel = FruitListViewModelFactory.Create(FruitsFactory.Create().OrderBy(f => (r.Next())).Take(3));

			return View(viewModel);
		}
	}
}