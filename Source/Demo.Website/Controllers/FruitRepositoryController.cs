using Demo.Fruit;
using Demo.Website.Models.Fruit;
using System.Web.Http;

namespace Demo.Website.Controllers
{
    public class FruitRepositoryController : ApiController
    {
		protected readonly IFruitItemRepository FruitItemRepository;

		public FruitRepositoryController(
			IFruitItemRepository fruitItemRepository)
		{
			FruitItemRepository = fruitItemRepository;
		}

		[HttpPost]
		public IHttpActionResult Create(CreateFruitRequest request)
		{
			var created = false;
			var valid = !string.IsNullOrWhiteSpace(request.Name) &&
						!string.IsNullOrWhiteSpace(request.Colours) &&
						!string.IsNullOrEmpty(request.Description);

			if (valid)
			{
				created = FruitItemRepository.Create(request) != null;
			}

			return Ok(new { created = created });
		}
	}
}
