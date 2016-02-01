using Demo.Fruit;
using System.ComponentModel.DataAnnotations;

namespace Demo.Website.Models.Fruit
{
	public class CreateFruitRequest : IFruit
	{
		[Required]
		public string Name { get; set; }
		[Required]
		public string Colours { get; set; }
		public string Description { get; set; }
		public string Title => Name;
		public string Colour => Colours;
	}
}