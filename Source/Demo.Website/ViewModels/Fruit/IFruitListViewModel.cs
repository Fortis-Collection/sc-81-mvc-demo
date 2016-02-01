using System.Collections.Generic;
using System.Web;

namespace Demo.Website.ViewModels.Fruit
{
	public interface IFruitListViewModel
	{
		List<IFruitListItemViewModel> Fruit { get; }
		IHtmlString NameColumnHeaderText { get; }
		IHtmlString ImageColumnHeaderText { get; }
		IHtmlString ColourColumnHeaderText { get; }
		IHtmlString DescriptionColumnHeaderText { get; }
	}
}
