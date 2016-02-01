using Fortis.Model.Fields;

namespace Demo.Website.ViewModels.Fruit
{
	public interface IFruitListItemViewModel
	{
		ITextFieldWrapper Name { get; }
		IImageFieldWrapper Image { get; }
		ITextFieldWrapper Colour { get; }
		IRichTextFieldWrapper Description { get; }
	}
}
