using Fortis.Model.Fields;

namespace Demo.Website.ViewModels.Fruit
{
	public class FruitListItemViewModel : IFruitListItemViewModel
	{
		public ITextFieldWrapper Name { get; set; }
		public IImageFieldWrapper Image { get; set; }
		public ITextFieldWrapper Colour { get; set; }
		public IRichTextFieldWrapper Description { get; set; }
	}
}