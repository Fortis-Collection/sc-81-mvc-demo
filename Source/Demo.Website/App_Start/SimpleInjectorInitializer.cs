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
	public static class SimpleInjectorInitializer
    {
        /// <summary>Initialize the container and register it as MVC3 Dependency Resolver.</summary>
        public static void Initialize()
        {
            var container = new Container();
            container.Options.DefaultScopedLifestyle = new WebRequestLifestyle();
            
            InitializeContainer(container);

            container.RegisterMvcControllers(Assembly.GetExecutingAssembly());
            
            container.Verify();
            
            DependencyResolver.SetResolver(new SimpleInjectorDependencyResolver(container));
        }
     
        private static void InitializeContainer(Container container)
        {
			InitializeFortis(container);
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