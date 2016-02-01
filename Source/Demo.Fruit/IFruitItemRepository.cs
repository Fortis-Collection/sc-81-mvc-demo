using Demo.Model.Templates.UserDefined;

namespace Demo.Fruit
{
	public interface IFruitItemRepository
	{
		IFruitItem Create(IFruit fruit);
	}
}
