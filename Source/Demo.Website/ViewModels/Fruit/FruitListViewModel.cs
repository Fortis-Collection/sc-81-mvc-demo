using System.Collections.Generic;
using System.Web;

namespace Demo.Website.ViewModels.Fruit
{
	public class FruitListViewModel : IFruitListViewModel
	{
		public List<IFruitListItemViewModel> Fruit { get; set; }
		public IHtmlString NameColumnHeaderText { get; set; }
		public IHtmlString ImageColumnHeaderText { get; set; }
		public IHtmlString ColourColumnHeaderText { get; set; }
		public IHtmlString DescriptionColumnHeaderText { get; set; }
	}
}