using Demo.Model.Templates.UserDefined;

namespace Demo.Website.ViewModels.Fruit
{
	public interface IFruitListItemViewModelFactory
	{
		IFruitListItemViewModel Create(IFruitItem fruit);
	}
}
