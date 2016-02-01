using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Demo.Model.Templates.UserDefined;
using Sitecore.Data.Items;
using Sitecore.SecurityModel;
using Sitecore.Data;
using Fortis.Model;

namespace Demo.Fruit
{
	public class FruitItemRepository : IFruitItemRepository
	{
		protected readonly IItemFactory ItemFactory;

		public FruitItemRepository(
			IItemFactory itemFactory)
		{
			ItemFactory = itemFactory;
		}

		public IFruitItem Create(IFruit fruit)
		{
			var name = ItemUtil.ProposeValidItemName(fruit.Title);

			using (new SecurityDisabler())
			{
				using (new DatabaseSwitcher(Database.GetDatabase("master")))
				{
					var fruitItem = ItemFactory.Create<IFruitItem>(new Guid("{1C66BBD6-BA2F-424B-A32F-26244D4AECD3}"), name);

					if (fruitItem != null)
					{
						fruitItem.Title.RawValue = fruit.Title;
						fruitItem.Colour.RawValue =fruit.Colour;
						fruitItem.Body.RawValue = fruit.Description;

						fruitItem.Save();
						fruitItem.Publish();

						return fruitItem;
					}
				}
			}

			return null;
		}
	}
}
