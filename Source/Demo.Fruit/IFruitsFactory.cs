using Demo.Model.Templates.UserDefined;
using System.Collections.Generic;

namespace Demo.Fruit
{
	public interface IFruitsFactory
	{
		IEnumerable<IFruitItem> Create();
	}
}
