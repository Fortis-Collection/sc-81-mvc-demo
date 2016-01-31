using Fortis.Model;
using Fortis.Providers;
using Sitecore.Data.Items;
using System;
using System.Collections.Generic;

namespace Demo.Model
{
	public class CustomItemWrapper : ItemWrapper, ICustomItemWrapper
	{
		public CustomItemWrapper(ISpawnProvider spawnProvider) : base(null, spawnProvider) { }

		public CustomItemWrapper(Guid id, ISpawnProvider spawnProvider) : base(id, spawnProvider) { }

		public CustomItemWrapper(Guid id, Dictionary<string, object> lazyFields, ISpawnProvider spawnProvider) : base(id, lazyFields, spawnProvider) { }

		public CustomItemWrapper(Item item, ISpawnProvider spawnProvider) : base(item, spawnProvider) { }
	}
}
