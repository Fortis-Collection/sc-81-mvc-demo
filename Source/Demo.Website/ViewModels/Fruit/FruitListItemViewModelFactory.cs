using Demo.Model.Templates.UserDefined;

namespace Demo.Website.ViewModels.Fruit
{
	public class FruitListItemViewModelFactory : IFruitListItemViewModelFactory
	{
		public IFruitListItemViewModel Create(IFruitItem fruit)
		{
			return new FruitListItemViewModel
			{
				Colour = fruit.Colour,
				Image = fruit.Image,
				Name = fruit.Title,
				Description = fruit.Body
			};
		}
	}
}