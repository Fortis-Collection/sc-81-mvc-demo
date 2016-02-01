[assembly: WebActivator.PostApplicationStartMethod(typeof(Demo.Website.App_Start.SimpleInjectorInitializer), "Initialize")]

namespace Demo.Website.App_Start
{
	using System.Reflection;
	using System.Web.Mvc;

	using SimpleInjector;
	using SimpleInjector.Extensions;
	using SimpleInjector.Integration.Web;
	using SimpleInjector.Integration.Web.Mvc;
	using Fortis.Model;
	using Fortis.Providers;
	using Fortis.Search;
	using Fortis;
	using Fortis.Mvc.Providers;
	using ViewModels.Fruit;
	using Fruit;
	using System.Web.Http;
	using SimpleInjector.Integration.WebApi;
	public static class SimpleInjectorInitializer
    {
        /// <summary>Initialize the container and register it as MVC3 Dependency Resolver.</summary>
        public static void Initialize()
        {
            var container = new Container();
            container.Options.DefaultScopedLifestyle = new WebRequestLifestyle();
            
            InitializeContainer(container);

            container.RegisterMvcControllers(Assembly.GetExecutingAssembly());
			container.RegisterWebApiControllers(GlobalConfiguration.Configuration, Assembly.GetExecutingAssembly());

			InitializeFortis(container);

			container.Verify();
            
            DependencyResolver.SetResolver(new SimpleInjectorDependencyResolver(container));
			GlobalConfiguration.Configuration.DependencyResolver = new SimpleInjectorWebApiDependencyResolver(container);
		}
     
        private static void InitializeContainer(Container container)
        {
			InitializeFruit(container);
		}

		public static void InitializeFruit(Container container)
		{
			container.RegisterSingleton<IFruitsFactory, FruitsFactory>();
			container.RegisterSingleton<IFruitItemRepository, FruitItemRepository>();
			container.RegisterSingleton<IFruitListViewModelFactory, FruitListViewModelFactory>();
			container.RegisterSingleton<IFruitListItemViewModelFactory, FruitListItemViewModelFactory>();
		}

		private static void InitializeFortis(Container container)
		{
			// Register Fortis
			container.Register<IItemFactory, ItemFactory>(Lifestyle.Singleton);
			container.Register<IContextProvider, ContextProvider>(Lifestyle.Singleton);
			container.Register<ISpawnProvider, SpawnProvider>(Lifestyle.Singleton);
			container.Register<ITemplateMapProvider, TemplateMapProvider>(Lifestyle.Singleton);
			container.Register<IModelAssemblyProvider, ModelAssemblyProvider>(Lifestyle.Singleton);
			container.Register<IItemSearchFactory, ItemSearchFactory>(Lifestyle.Singleton);
			container.Register<ISearchResultsAdapter, SearchResultsAdapter>(Lifestyle.Singleton);

			// Initialise fortis - this is required for places where we can't use DI
			Global.Initialise(
				container.GetInstance<ISpawnProvider>(),
				container.GetInstance<IItemFactory>(),
				container.GetInstance<IItemSearchFactory>()
			);
		}
	}
}