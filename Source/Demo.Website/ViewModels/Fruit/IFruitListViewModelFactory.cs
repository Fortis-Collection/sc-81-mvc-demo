using Demo.Model.Templates.UserDefined;
using System.Collections.Generic;

namespace Demo.Website.ViewModels.Fruit
{
	public interface IFruitListViewModelFactory
	{
		IFruitListViewModel Create(IEnumerable<IFruitItem> fruit);
	}
}
