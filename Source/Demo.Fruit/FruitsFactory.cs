using System;
using System.Collections.Generic;
using Demo.Model.Templates.UserDefined;
using Fortis.Model;

namespace Demo.Fruit
{
	public class FruitsFactory : IFruitsFactory
	{
		protected readonly IItemFactory ItemFactory;

		public FruitsFactory(
			IItemFactory itemFactory)
		{
			ItemFactory = itemFactory;
		}

		public IEnumerable<IFruitItem> Create()
		{
			return ItemFactory.Select<IItemWrapper>(new Guid("{1C66BBD6-BA2F-424B-A32F-26244D4AECD3}")).Children<IFruitItem>();
		}
	}
}
