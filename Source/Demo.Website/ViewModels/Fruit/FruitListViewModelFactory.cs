using Demo.Model.Templates.UserDefined;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Demo.Website.ViewModels.Fruit
{
	public class FruitListViewModelFactory : IFruitListViewModelFactory
	{
		protected readonly IFruitListItemViewModelFactory ItemViewModelFactory;

		public FruitListViewModelFactory(
			IFruitListItemViewModelFactory itemViewModelFactory)
		{
			ItemViewModelFactory = itemViewModelFactory;
		}

		public IFruitListViewModel Create(IEnumerable<IFruitItem> fruit)
		{
			return new FruitListViewModel
			{
				Fruit = fruit.Select(f => ItemViewModelFactory.Create(f)).ToList(),
				ColourColumnHeaderText = new HtmlString("Colour"),
				ImageColumnHeaderText = new HtmlString("Image"),
				NameColumnHeaderText = new HtmlString("Name"),
				DescriptionColumnHeaderText = new HtmlString("Description")
			};
		}
	}
}