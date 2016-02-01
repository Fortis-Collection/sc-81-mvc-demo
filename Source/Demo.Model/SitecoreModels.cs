#region Content (UserDefined)
namespace Demo.Model.Templates.UserDefined
{
    using System;
	using System.Collections.Generic;
    using Sitecore.Data.Items;
	using Sitecore.ContentSearch;
	using Sitecore.ContentSearch.Linq.Common;
    using Fortis.Model;
	using Fortis.Model.Fields;
	using Fortis.Providers;


	/// <summary>
	/// <para>Template interface</para>
	/// <para>Template: Content</para>
	/// <para>ID: {0AD237CA-46E3-4F3E-A57F-C6F796F0CF0C}</para>
	/// <para>/sitecore/templates/User Defined/Generic/Content Chunks/Content</para>
	/// </summary>
	[TemplateMapping("{0AD237CA-46E3-4F3E-A57F-C6F796F0CF0C}", "InterfaceMap")]
	public partial interface IContentItem : ICustomItemWrapper , Demo.Model.Templates.UserDefined.IDemoStandardTemplateItem, Demo.Model.Templates.UserDefined.IContentTitleItem, Demo.Model.Templates.UserDefined.IContentBodyItem, Demo.Model.Templates.UserDefined.IContentImageItem
	{		
	}

	/// <summary>
	/// <para>Template class</para><para>/sitecore/templates/User Defined/Generic/Content Chunks/Content</para>
	/// </summary>
	[PredefinedQuery("TemplateId", ComparisonType.Equal, "{0AD237CA-46E3-4F3E-A57F-C6F796F0CF0C}", typeof(Guid))]
	[TemplateMapping("{0AD237CA-46E3-4F3E-A57F-C6F796F0CF0C}", "")]
	public partial class ContentItem : CustomItemWrapper, IContentItem
	{
		private Item _item = null;

		public ContentItem(ISpawnProvider spawnProvider) : base(null, spawnProvider) { }

		public ContentItem(Guid id, ISpawnProvider spawnProvider) : base(id, spawnProvider) { }

		public ContentItem(Guid id, Dictionary<string, object> lazyFields, ISpawnProvider spawnProvider) : base(id, lazyFields, spawnProvider) { }

		public ContentItem(Item item, ISpawnProvider spawnProvider) : base(item, spawnProvider)
		{
			_item = item;
		}

		/// <summary><para>Template: Content</para><para>Field: Title</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("title_t")]
		public virtual ITextFieldWrapper Title
		{
			get { return GetField<TextFieldWrapper>("Title", "title_t"); }
		}

		/// <summary><para>Template: Content</para><para>Field: Title</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("title")]
 		public string TitleValue
		{
			get { return Title.Value; }
		}
		/// <summary><para>Template: Content</para><para>Field: Body</para><para>Data type: Rich Text</para></summary>
		[IndexField("body_t")]
		public virtual IRichTextFieldWrapper Body
		{
			get { return GetField<RichTextFieldWrapper>("Body", "body_t"); }
		}

		/// <summary><para>Template: Content</para><para>Field: Body</para><para>Data type: Rich Text</para></summary>
		[IndexField("body")]
 		public string BodyValue
		{
			get { return Body.Value; }
		}
		/// <summary><para>Template: Content</para><para>Field: Image</para><para>Data type: Image</para></summary>
		public virtual IImageFieldWrapper Image
		{
			get { return GetField<ImageFieldWrapper>("Image"); }
		}

		/// <summary><para>Template: Content</para><para>Field: Image</para><para>Data type: Image</para></summary>
 		public string ImageValue
		{
			get { return Image.Value; }
		}
	
	}
}
#endregion
#region Demo Standard Template (UserDefined)
namespace Demo.Model.Templates.UserDefined
{
    using System;
	using System.Collections.Generic;
    using Sitecore.Data.Items;
	using Sitecore.ContentSearch;
	using Sitecore.ContentSearch.Linq.Common;
    using Fortis.Model;
	using Fortis.Model.Fields;
	using Fortis.Providers;


	/// <summary>
	/// <para>Template interface</para>
	/// <para>Template: Demo Standard Template</para>
	/// <para>ID: {147A11EF-8721-4211-8D27-776E2B02A2AC}</para>
	/// <para>/sitecore/templates/User Defined/Demo Standard Template</para>
	/// </summary>
	[TemplateMapping("{147A11EF-8721-4211-8D27-776E2B02A2AC}", "InterfaceMap")]
	public partial interface IDemoStandardTemplateItem : ICustomItemWrapper 
	{		
	}

	/// <summary>
	/// <para>Template class</para><para>/sitecore/templates/User Defined/Demo Standard Template</para>
	/// </summary>
	[PredefinedQuery("TemplateId", ComparisonType.Equal, "{147A11EF-8721-4211-8D27-776E2B02A2AC}", typeof(Guid))]
	[TemplateMapping("{147A11EF-8721-4211-8D27-776E2B02A2AC}", "")]
	public partial class DemoStandardTemplateItem : CustomItemWrapper, IDemoStandardTemplateItem
	{
		private Item _item = null;

		public DemoStandardTemplateItem(ISpawnProvider spawnProvider) : base(null, spawnProvider) { }

		public DemoStandardTemplateItem(Guid id, ISpawnProvider spawnProvider) : base(id, spawnProvider) { }

		public DemoStandardTemplateItem(Guid id, Dictionary<string, object> lazyFields, ISpawnProvider spawnProvider) : base(id, lazyFields, spawnProvider) { }

		public DemoStandardTemplateItem(Item item, ISpawnProvider spawnProvider) : base(item, spawnProvider)
		{
			_item = item;
		}

	
	}
}
#endregion
#region Fruit (UserDefined)
namespace Demo.Model.Templates.UserDefined
{
    using System;
	using System.Collections.Generic;
    using Sitecore.Data.Items;
	using Sitecore.ContentSearch;
	using Sitecore.ContentSearch.Linq.Common;
    using Fortis.Model;
	using Fortis.Model.Fields;
	using Fortis.Providers;


	/// <summary>
	/// <para>Template interface</para>
	/// <para>Template: Fruit</para>
	/// <para>ID: {161F256D-C715-4E77-B4BB-98C671FA31AE}</para>
	/// <para>/sitecore/templates/User Defined/Fruit/Fruit</para>
	/// </summary>
	[TemplateMapping("{161F256D-C715-4E77-B4BB-98C671FA31AE}", "InterfaceMap")]
	public partial interface IFruitItem : ICustomItemWrapper , Demo.Model.Templates.UserDefined.IDemoStandardTemplateItem, Demo.Model.Templates.UserDefined.IContentTitleItem, Demo.Model.Templates.UserDefined.IContentImageItem, Demo.Model.Templates.UserDefined.IContentBodyItem
	{		
    	/// <summary>
		/// <para>Template: Fruit</para><para>Field: Colour</para><para>Data type: Single-Line Text</para>
        /// </summary>
		[IndexField("colour_t")]
		ITextFieldWrapper Colour { get; }

    	/// <summary>
		/// <para>Template: Fruit</para><para>Field: Colour</para><para>Data type: Single-Line Text</para>
        /// </summary>
		[IndexField("colour")]
 		string ColourValue { get; }
	}

	/// <summary>
	/// <para>Template class</para><para>/sitecore/templates/User Defined/Fruit/Fruit</para>
	/// </summary>
	[PredefinedQuery("TemplateId", ComparisonType.Equal, "{161F256D-C715-4E77-B4BB-98C671FA31AE}", typeof(Guid))]
	[TemplateMapping("{161F256D-C715-4E77-B4BB-98C671FA31AE}", "")]
	public partial class FruitItem : CustomItemWrapper, IFruitItem
	{
		private Item _item = null;

		public FruitItem(ISpawnProvider spawnProvider) : base(null, spawnProvider) { }

		public FruitItem(Guid id, ISpawnProvider spawnProvider) : base(id, spawnProvider) { }

		public FruitItem(Guid id, Dictionary<string, object> lazyFields, ISpawnProvider spawnProvider) : base(id, lazyFields, spawnProvider) { }

		public FruitItem(Item item, ISpawnProvider spawnProvider) : base(item, spawnProvider)
		{
			_item = item;
		}

		/// <summary><para>Template: Fruit</para><para>Field: Title</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("title_t")]
		public virtual ITextFieldWrapper Title
		{
			get { return GetField<TextFieldWrapper>("Title", "title_t"); }
		}

		/// <summary><para>Template: Fruit</para><para>Field: Title</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("title")]
 		public string TitleValue
		{
			get { return Title.Value; }
		}
		/// <summary><para>Template: Fruit</para><para>Field: Image</para><para>Data type: Image</para></summary>
		public virtual IImageFieldWrapper Image
		{
			get { return GetField<ImageFieldWrapper>("Image"); }
		}

		/// <summary><para>Template: Fruit</para><para>Field: Image</para><para>Data type: Image</para></summary>
 		public string ImageValue
		{
			get { return Image.Value; }
		}
		/// <summary><para>Template: Fruit</para><para>Field: Body</para><para>Data type: Rich Text</para></summary>
		[IndexField("body_t")]
		public virtual IRichTextFieldWrapper Body
		{
			get { return GetField<RichTextFieldWrapper>("Body", "body_t"); }
		}

		/// <summary><para>Template: Fruit</para><para>Field: Body</para><para>Data type: Rich Text</para></summary>
		[IndexField("body")]
 		public string BodyValue
		{
			get { return Body.Value; }
		}
		/// <summary><para>Template: Fruit</para><para>Field: Colour</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("colour_t")]
		public virtual ITextFieldWrapper Colour
		{
			get { return GetField<TextFieldWrapper>("Colour", "colour_t"); }
		}

		/// <summary><para>Template: Fruit</para><para>Field: Colour</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("colour")]
 		public string ColourValue
		{
			get { return Colour.Value; }
		}
	
	}
}
#endregion
#region Page (UserDefined)
namespace Demo.Model.Templates.UserDefined
{
    using System;
	using System.Collections.Generic;
    using Sitecore.Data.Items;
	using Sitecore.ContentSearch;
	using Sitecore.ContentSearch.Linq.Common;
    using Fortis.Model;
	using Fortis.Model.Fields;
	using Fortis.Providers;


	/// <summary>
	/// <para>Template interface</para>
	/// <para>Template: Page</para>
	/// <para>ID: {5E874F90-6493-4994-9C83-4C8A93347506}</para>
	/// <para>/sitecore/templates/User Defined/Generic/Page</para>
	/// </summary>
	[TemplateMapping("{5E874F90-6493-4994-9C83-4C8A93347506}", "InterfaceMap")]
	public partial interface IPageItem : ICustomItemWrapper , Demo.Model.Templates.UserDefined.IDemoStandardTemplateItem, Demo.Model.Templates.UserDefined.IContentItem
	{		
	}

	/// <summary>
	/// <para>Template class</para><para>/sitecore/templates/User Defined/Generic/Page</para>
	/// </summary>
	[PredefinedQuery("TemplateId", ComparisonType.Equal, "{5E874F90-6493-4994-9C83-4C8A93347506}", typeof(Guid))]
	[TemplateMapping("{5E874F90-6493-4994-9C83-4C8A93347506}", "")]
	public partial class PageItem : CustomItemWrapper, IPageItem
	{
		private Item _item = null;

		public PageItem(ISpawnProvider spawnProvider) : base(null, spawnProvider) { }

		public PageItem(Guid id, ISpawnProvider spawnProvider) : base(id, spawnProvider) { }

		public PageItem(Guid id, Dictionary<string, object> lazyFields, ISpawnProvider spawnProvider) : base(id, lazyFields, spawnProvider) { }

		public PageItem(Item item, ISpawnProvider spawnProvider) : base(item, spawnProvider)
		{
			_item = item;
		}

		/// <summary><para>Template: Page</para><para>Field: Title</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("title_t")]
		public virtual ITextFieldWrapper Title
		{
			get { return GetField<TextFieldWrapper>("Title", "title_t"); }
		}

		/// <summary><para>Template: Page</para><para>Field: Title</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("title")]
 		public string TitleValue
		{
			get { return Title.Value; }
		}
		/// <summary><para>Template: Page</para><para>Field: Body</para><para>Data type: Rich Text</para></summary>
		[IndexField("body_t")]
		public virtual IRichTextFieldWrapper Body
		{
			get { return GetField<RichTextFieldWrapper>("Body", "body_t"); }
		}

		/// <summary><para>Template: Page</para><para>Field: Body</para><para>Data type: Rich Text</para></summary>
		[IndexField("body")]
 		public string BodyValue
		{
			get { return Body.Value; }
		}
		/// <summary><para>Template: Page</para><para>Field: Image</para><para>Data type: Image</para></summary>
		public virtual IImageFieldWrapper Image
		{
			get { return GetField<ImageFieldWrapper>("Image"); }
		}

		/// <summary><para>Template: Page</para><para>Field: Image</para><para>Data type: Image</para></summary>
 		public string ImageValue
		{
			get { return Image.Value; }
		}
	
	}
}
#endregion
#region Content Body (UserDefined)
namespace Demo.Model.Templates.UserDefined
{
    using System;
	using System.Collections.Generic;
    using Sitecore.Data.Items;
	using Sitecore.ContentSearch;
	using Sitecore.ContentSearch.Linq.Common;
    using Fortis.Model;
	using Fortis.Model.Fields;
	using Fortis.Providers;


	/// <summary>
	/// <para>Template interface</para>
	/// <para>Template: Content Body</para>
	/// <para>ID: {76CBCC5A-7ADA-4701-A2EC-227A0A15706E}</para>
	/// <para>/sitecore/templates/User Defined/Generic/Content Chunks/Content Body</para>
	/// </summary>
	[TemplateMapping("{76CBCC5A-7ADA-4701-A2EC-227A0A15706E}", "InterfaceMap")]
	public partial interface IContentBodyItem : ICustomItemWrapper , Demo.Model.Templates.UserDefined.IDemoStandardTemplateItem
	{		
    	/// <summary>
		/// <para>Template: Content Body</para><para>Field: Body</para><para>Data type: Rich Text</para>
        /// </summary>
		[IndexField("body_t")]
		IRichTextFieldWrapper Body { get; }

    	/// <summary>
		/// <para>Template: Content Body</para><para>Field: Body</para><para>Data type: Rich Text</para>
        /// </summary>
		[IndexField("body")]
 		string BodyValue { get; }
	}

	/// <summary>
	/// <para>Template class</para><para>/sitecore/templates/User Defined/Generic/Content Chunks/Content Body</para>
	/// </summary>
	[PredefinedQuery("TemplateId", ComparisonType.Equal, "{76CBCC5A-7ADA-4701-A2EC-227A0A15706E}", typeof(Guid))]
	[TemplateMapping("{76CBCC5A-7ADA-4701-A2EC-227A0A15706E}", "")]
	public partial class ContentBodyItem : CustomItemWrapper, IContentBodyItem
	{
		private Item _item = null;

		public ContentBodyItem(ISpawnProvider spawnProvider) : base(null, spawnProvider) { }

		public ContentBodyItem(Guid id, ISpawnProvider spawnProvider) : base(id, spawnProvider) { }

		public ContentBodyItem(Guid id, Dictionary<string, object> lazyFields, ISpawnProvider spawnProvider) : base(id, lazyFields, spawnProvider) { }

		public ContentBodyItem(Item item, ISpawnProvider spawnProvider) : base(item, spawnProvider)
		{
			_item = item;
		}

		/// <summary><para>Template: Content Body</para><para>Field: Body</para><para>Data type: Rich Text</para></summary>
		[IndexField("body_t")]
		public virtual IRichTextFieldWrapper Body
		{
			get { return GetField<RichTextFieldWrapper>("Body", "body_t"); }
		}

		/// <summary><para>Template: Content Body</para><para>Field: Body</para><para>Data type: Rich Text</para></summary>
		[IndexField("body")]
 		public string BodyValue
		{
			get { return Body.Value; }
		}
	
	}
}
#endregion
#region General Page (UserDefined)
namespace Demo.Model.Templates.UserDefined
{
    using System;
	using System.Collections.Generic;
    using Sitecore.Data.Items;
	using Sitecore.ContentSearch;
	using Sitecore.ContentSearch.Linq.Common;
    using Fortis.Model;
	using Fortis.Model.Fields;
	using Fortis.Providers;


	/// <summary>
	/// <para>Template interface</para>
	/// <para>Template: General Page</para>
	/// <para>ID: {79589439-529E-412D-9B9C-8D2B3751F424}</para>
	/// <para>/sitecore/templates/User Defined/Generic/General Page</para>
	/// </summary>
	[TemplateMapping("{79589439-529E-412D-9B9C-8D2B3751F424}", "InterfaceMap")]
	public partial interface IGeneralPageItem : ICustomItemWrapper , Demo.Model.Templates.UserDefined.IDemoStandardTemplateItem, Demo.Model.Templates.UserDefined.IPageItem
	{		
	}

	/// <summary>
	/// <para>Template class</para><para>/sitecore/templates/User Defined/Generic/General Page</para>
	/// </summary>
	[PredefinedQuery("TemplateId", ComparisonType.Equal, "{79589439-529E-412D-9B9C-8D2B3751F424}", typeof(Guid))]
	[TemplateMapping("{79589439-529E-412D-9B9C-8D2B3751F424}", "")]
	public partial class GeneralPageItem : CustomItemWrapper, IGeneralPageItem
	{
		private Item _item = null;

		public GeneralPageItem(ISpawnProvider spawnProvider) : base(null, spawnProvider) { }

		public GeneralPageItem(Guid id, ISpawnProvider spawnProvider) : base(id, spawnProvider) { }

		public GeneralPageItem(Guid id, Dictionary<string, object> lazyFields, ISpawnProvider spawnProvider) : base(id, lazyFields, spawnProvider) { }

		public GeneralPageItem(Item item, ISpawnProvider spawnProvider) : base(item, spawnProvider)
		{
			_item = item;
		}

		/// <summary><para>Template: General Page</para><para>Field: Title</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("title_t")]
		public virtual ITextFieldWrapper Title
		{
			get { return GetField<TextFieldWrapper>("Title", "title_t"); }
		}

		/// <summary><para>Template: General Page</para><para>Field: Title</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("title")]
 		public string TitleValue
		{
			get { return Title.Value; }
		}
		/// <summary><para>Template: General Page</para><para>Field: Body</para><para>Data type: Rich Text</para></summary>
		[IndexField("body_t")]
		public virtual IRichTextFieldWrapper Body
		{
			get { return GetField<RichTextFieldWrapper>("Body", "body_t"); }
		}

		/// <summary><para>Template: General Page</para><para>Field: Body</para><para>Data type: Rich Text</para></summary>
		[IndexField("body")]
 		public string BodyValue
		{
			get { return Body.Value; }
		}
		/// <summary><para>Template: General Page</para><para>Field: Image</para><para>Data type: Image</para></summary>
		public virtual IImageFieldWrapper Image
		{
			get { return GetField<ImageFieldWrapper>("Image"); }
		}

		/// <summary><para>Template: General Page</para><para>Field: Image</para><para>Data type: Image</para></summary>
 		public string ImageValue
		{
			get { return Image.Value; }
		}
	
	}
}
#endregion
#region Demo Standard Rendering Parameters (UserDefined)
namespace Demo.Model.Templates.UserDefined
{
    using System;
	using System.Collections.Generic;
    using Sitecore.Data.Items;
	using Sitecore.ContentSearch;
	using Sitecore.ContentSearch.Linq.Common;
    using Fortis.Model;
	using Fortis.Model.Fields;
	using Fortis.Providers;

    using Fortis.Model.RenderingParameters;

	/// <summary>
	/// <para>Template interface</para>
	/// <para>Template: Demo Standard Rendering Parameters</para>
	/// <para>ID: {8B64EBB3-0C3E-488C-A34A-1369FA2E8C36}</para>
	/// <para>/sitecore/templates/User Defined/Demo Standard Rendering Parameters</para>
	/// </summary>
	[TemplateMapping("{8B64EBB3-0C3E-488C-A34A-1369FA2E8C36}", "InterfaceRenderingParameter")]
	public partial interface IDemoStandardRenderingParametersItem : IRenderingParameterWrapper 
	{		
	}

	/// <summary>
	/// <para>Template class</para><para>/sitecore/templates/User Defined/Demo Standard Rendering Parameters</para>
	/// </summary>
	[PredefinedQuery("TemplateId", ComparisonType.Equal, "{8B64EBB3-0C3E-488C-A34A-1369FA2E8C36}", typeof(Guid))]
	[TemplateMapping("{8B64EBB3-0C3E-488C-A34A-1369FA2E8C36}", "RenderingParameter")]
	public partial class DemoStandardRenderingParametersItem : RenderingParameterWrapper, IDemoStandardRenderingParametersItem
	{
		public DemoStandardRenderingParametersItem(Dictionary<string, string> parameters, ISpawnProvider spawnProvider) : base(parameters, spawnProvider)
		{
		}

	
	}
}
#endregion
#region Content Image (UserDefined)
namespace Demo.Model.Templates.UserDefined
{
    using System;
	using System.Collections.Generic;
    using Sitecore.Data.Items;
	using Sitecore.ContentSearch;
	using Sitecore.ContentSearch.Linq.Common;
    using Fortis.Model;
	using Fortis.Model.Fields;
	using Fortis.Providers;


	/// <summary>
	/// <para>Template interface</para>
	/// <para>Template: Content Image</para>
	/// <para>ID: {99939C77-DD46-4DFF-BDCD-5F03902E61DE}</para>
	/// <para>/sitecore/templates/User Defined/Generic/Content Chunks/Content Image</para>
	/// </summary>
	[TemplateMapping("{99939C77-DD46-4DFF-BDCD-5F03902E61DE}", "InterfaceMap")]
	public partial interface IContentImageItem : ICustomItemWrapper , Demo.Model.Templates.UserDefined.IDemoStandardTemplateItem
	{		
    	/// <summary>
		/// <para>Template: Content Image</para><para>Field: Image</para><para>Data type: Image</para>
        /// </summary>
		IImageFieldWrapper Image { get; }
 		string ImageValue { get; }
	}

	/// <summary>
	/// <para>Template class</para><para>/sitecore/templates/User Defined/Generic/Content Chunks/Content Image</para>
	/// </summary>
	[PredefinedQuery("TemplateId", ComparisonType.Equal, "{99939C77-DD46-4DFF-BDCD-5F03902E61DE}", typeof(Guid))]
	[TemplateMapping("{99939C77-DD46-4DFF-BDCD-5F03902E61DE}", "")]
	public partial class ContentImageItem : CustomItemWrapper, IContentImageItem
	{
		private Item _item = null;

		public ContentImageItem(ISpawnProvider spawnProvider) : base(null, spawnProvider) { }

		public ContentImageItem(Guid id, ISpawnProvider spawnProvider) : base(id, spawnProvider) { }

		public ContentImageItem(Guid id, Dictionary<string, object> lazyFields, ISpawnProvider spawnProvider) : base(id, lazyFields, spawnProvider) { }

		public ContentImageItem(Item item, ISpawnProvider spawnProvider) : base(item, spawnProvider)
		{
			_item = item;
		}

		/// <summary><para>Template: Content Image</para><para>Field: Image</para><para>Data type: Image</para></summary>
		public virtual IImageFieldWrapper Image
		{
			get { return GetField<ImageFieldWrapper>("Image"); }
		}

		/// <summary><para>Template: Content Image</para><para>Field: Image</para><para>Data type: Image</para></summary>
 		public string ImageValue
		{
			get { return Image.Value; }
		}
	
	}
}
#endregion
#region Content Title (UserDefined)
namespace Demo.Model.Templates.UserDefined
{
    using System;
	using System.Collections.Generic;
    using Sitecore.Data.Items;
	using Sitecore.ContentSearch;
	using Sitecore.ContentSearch.Linq.Common;
    using Fortis.Model;
	using Fortis.Model.Fields;
	using Fortis.Providers;


	/// <summary>
	/// <para>Template interface</para>
	/// <para>Template: Content Title</para>
	/// <para>ID: {D151A208-03A0-413F-8933-B1E9F2089A76}</para>
	/// <para>/sitecore/templates/User Defined/Generic/Content Chunks/Content Title</para>
	/// </summary>
	[TemplateMapping("{D151A208-03A0-413F-8933-B1E9F2089A76}", "InterfaceMap")]
	public partial interface IContentTitleItem : ICustomItemWrapper , Demo.Model.Templates.UserDefined.IDemoStandardTemplateItem
	{		
    	/// <summary>
		/// <para>Template: Content Title</para><para>Field: Title</para><para>Data type: Single-Line Text</para>
        /// </summary>
		[IndexField("title_t")]
		ITextFieldWrapper Title { get; }

    	/// <summary>
		/// <para>Template: Content Title</para><para>Field: Title</para><para>Data type: Single-Line Text</para>
        /// </summary>
		[IndexField("title")]
 		string TitleValue { get; }
	}

	/// <summary>
	/// <para>Template class</para><para>/sitecore/templates/User Defined/Generic/Content Chunks/Content Title</para>
	/// </summary>
	[PredefinedQuery("TemplateId", ComparisonType.Equal, "{D151A208-03A0-413F-8933-B1E9F2089A76}", typeof(Guid))]
	[TemplateMapping("{D151A208-03A0-413F-8933-B1E9F2089A76}", "")]
	public partial class ContentTitleItem : CustomItemWrapper, IContentTitleItem
	{
		private Item _item = null;

		public ContentTitleItem(ISpawnProvider spawnProvider) : base(null, spawnProvider) { }

		public ContentTitleItem(Guid id, ISpawnProvider spawnProvider) : base(id, spawnProvider) { }

		public ContentTitleItem(Guid id, Dictionary<string, object> lazyFields, ISpawnProvider spawnProvider) : base(id, lazyFields, spawnProvider) { }

		public ContentTitleItem(Item item, ISpawnProvider spawnProvider) : base(item, spawnProvider)
		{
			_item = item;
		}

		/// <summary><para>Template: Content Title</para><para>Field: Title</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("title_t")]
		public virtual ITextFieldWrapper Title
		{
			get { return GetField<TextFieldWrapper>("Title", "title_t"); }
		}

		/// <summary><para>Template: Content Title</para><para>Field: Title</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("title")]
 		public string TitleValue
		{
			get { return Title.Value; }
		}
	
	}
}
#endregion
#region Site Shared (UserDefined)
namespace Demo.Model.Templates.UserDefined
{
    using System;
	using System.Collections.Generic;
    using Sitecore.Data.Items;
	using Sitecore.ContentSearch;
	using Sitecore.ContentSearch.Linq.Common;
    using Fortis.Model;
	using Fortis.Model.Fields;
	using Fortis.Providers;


	/// <summary>
	/// <para>Template interface</para>
	/// <para>Template: Site Shared</para>
	/// <para>ID: {EACF012A-609F-454B-B1C5-68FB917F82A2}</para>
	/// <para>/sitecore/templates/User Defined/Site/Site Shared</para>
	/// </summary>
	[TemplateMapping("{EACF012A-609F-454B-B1C5-68FB917F82A2}", "InterfaceMap")]
	public partial interface ISiteSharedItem : ICustomItemWrapper , Demo.Model.Templates.UserDefined.IDemoStandardTemplateItem
	{		
	}

	/// <summary>
	/// <para>Template class</para><para>/sitecore/templates/User Defined/Site/Site Shared</para>
	/// </summary>
	[PredefinedQuery("TemplateId", ComparisonType.Equal, "{EACF012A-609F-454B-B1C5-68FB917F82A2}", typeof(Guid))]
	[TemplateMapping("{EACF012A-609F-454B-B1C5-68FB917F82A2}", "")]
	public partial class SiteSharedItem : CustomItemWrapper, ISiteSharedItem
	{
		private Item _item = null;

		public SiteSharedItem(ISpawnProvider spawnProvider) : base(null, spawnProvider) { }

		public SiteSharedItem(Guid id, ISpawnProvider spawnProvider) : base(id, spawnProvider) { }

		public SiteSharedItem(Guid id, Dictionary<string, object> lazyFields, ISpawnProvider spawnProvider) : base(id, lazyFields, spawnProvider) { }

		public SiteSharedItem(Item item, ISpawnProvider spawnProvider) : base(item, spawnProvider)
		{
			_item = item;
		}

	
	}
}
#endregion
#region Site Root (UserDefined)
namespace Demo.Model.Templates.UserDefined
{
    using System;
	using System.Collections.Generic;
    using Sitecore.Data.Items;
	using Sitecore.ContentSearch;
	using Sitecore.ContentSearch.Linq.Common;
    using Fortis.Model;
	using Fortis.Model.Fields;
	using Fortis.Providers;


	/// <summary>
	/// <para>Template interface</para>
	/// <para>Template: Site Root</para>
	/// <para>ID: {F5B5DCF2-703B-450D-A800-DFACB52E8BE2}</para>
	/// <para>/sitecore/templates/User Defined/Site/Site Root</para>
	/// </summary>
	[TemplateMapping("{F5B5DCF2-703B-450D-A800-DFACB52E8BE2}", "InterfaceMap")]
	public partial interface ISiteRootItem : ICustomItemWrapper , Demo.Model.Templates.UserDefined.IDemoStandardTemplateItem
	{		
	}

	/// <summary>
	/// <para>Template class</para><para>/sitecore/templates/User Defined/Site/Site Root</para>
	/// </summary>
	[PredefinedQuery("TemplateId", ComparisonType.Equal, "{F5B5DCF2-703B-450D-A800-DFACB52E8BE2}", typeof(Guid))]
	[TemplateMapping("{F5B5DCF2-703B-450D-A800-DFACB52E8BE2}", "")]
	public partial class SiteRootItem : CustomItemWrapper, ISiteRootItem
	{
		private Item _item = null;

		public SiteRootItem(ISpawnProvider spawnProvider) : base(null, spawnProvider) { }

		public SiteRootItem(Guid id, ISpawnProvider spawnProvider) : base(id, spawnProvider) { }

		public SiteRootItem(Guid id, Dictionary<string, object> lazyFields, ISpawnProvider spawnProvider) : base(id, lazyFields, spawnProvider) { }

		public SiteRootItem(Item item, ISpawnProvider spawnProvider) : base(item, spawnProvider)
		{
			_item = item;
		}

	
	}
}
#endregion
#region Fruit Folder (UserDefined)
namespace Demo.Model.Templates.UserDefined
{
    using System;
	using System.Collections.Generic;
    using Sitecore.Data.Items;
	using Sitecore.ContentSearch;
	using Sitecore.ContentSearch.Linq.Common;
    using Fortis.Model;
	using Fortis.Model.Fields;
	using Fortis.Providers;


	/// <summary>
	/// <para>Template interface</para>
	/// <para>Template: Fruit Folder</para>
	/// <para>ID: {F7F332ED-A626-42AF-AE5A-ED03AC6B486A}</para>
	/// <para>/sitecore/templates/User Defined/Fruit/Fruit Folder</para>
	/// </summary>
	[TemplateMapping("{F7F332ED-A626-42AF-AE5A-ED03AC6B486A}", "InterfaceMap")]
	public partial interface IFruitFolderItem : ICustomItemWrapper , Demo.Model.Templates.UserDefined.IDemoStandardTemplateItem
	{		
	}

	/// <summary>
	/// <para>Template class</para><para>/sitecore/templates/User Defined/Fruit/Fruit Folder</para>
	/// </summary>
	[PredefinedQuery("TemplateId", ComparisonType.Equal, "{F7F332ED-A626-42AF-AE5A-ED03AC6B486A}", typeof(Guid))]
	[TemplateMapping("{F7F332ED-A626-42AF-AE5A-ED03AC6B486A}", "")]
	public partial class FruitFolderItem : CustomItemWrapper, IFruitFolderItem
	{
		private Item _item = null;

		public FruitFolderItem(ISpawnProvider spawnProvider) : base(null, spawnProvider) { }

		public FruitFolderItem(Guid id, ISpawnProvider spawnProvider) : base(id, spawnProvider) { }

		public FruitFolderItem(Guid id, Dictionary<string, object> lazyFields, ISpawnProvider spawnProvider) : base(id, lazyFields, spawnProvider) { }

		public FruitFolderItem(Item item, ISpawnProvider spawnProvider) : base(item, spawnProvider)
		{
			_item = item;
		}

	
	}
}
#endregion
#region Site Home (UserDefined)
namespace Demo.Model.Templates.UserDefined
{
    using System;
	using System.Collections.Generic;
    using Sitecore.Data.Items;
	using Sitecore.ContentSearch;
	using Sitecore.ContentSearch.Linq.Common;
    using Fortis.Model;
	using Fortis.Model.Fields;
	using Fortis.Providers;


	/// <summary>
	/// <para>Template interface</para>
	/// <para>Template: Site Home</para>
	/// <para>ID: {FF55701A-0F87-482E-A66F-6D1EB75CAEA3}</para>
	/// <para>/sitecore/templates/User Defined/Site/Site Home</para>
	/// </summary>
	[TemplateMapping("{FF55701A-0F87-482E-A66F-6D1EB75CAEA3}", "InterfaceMap")]
	public partial interface ISiteHomeItem : ICustomItemWrapper , Demo.Model.Templates.UserDefined.IDemoStandardTemplateItem, Demo.Model.Templates.UserDefined.IPageItem
	{		
	}

	/// <summary>
	/// <para>Template class</para><para>/sitecore/templates/User Defined/Site/Site Home</para>
	/// </summary>
	[PredefinedQuery("TemplateId", ComparisonType.Equal, "{FF55701A-0F87-482E-A66F-6D1EB75CAEA3}", typeof(Guid))]
	[TemplateMapping("{FF55701A-0F87-482E-A66F-6D1EB75CAEA3}", "")]
	public partial class SiteHomeItem : CustomItemWrapper, ISiteHomeItem
	{
		private Item _item = null;

		public SiteHomeItem(ISpawnProvider spawnProvider) : base(null, spawnProvider) { }

		public SiteHomeItem(Guid id, ISpawnProvider spawnProvider) : base(id, spawnProvider) { }

		public SiteHomeItem(Guid id, Dictionary<string, object> lazyFields, ISpawnProvider spawnProvider) : base(id, lazyFields, spawnProvider) { }

		public SiteHomeItem(Item item, ISpawnProvider spawnProvider) : base(item, spawnProvider)
		{
			_item = item;
		}

		/// <summary><para>Template: Site Home</para><para>Field: Title</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("title_t")]
		public virtual ITextFieldWrapper Title
		{
			get { return GetField<TextFieldWrapper>("Title", "title_t"); }
		}

		/// <summary><para>Template: Site Home</para><para>Field: Title</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("title")]
 		public string TitleValue
		{
			get { return Title.Value; }
		}
		/// <summary><para>Template: Site Home</para><para>Field: Body</para><para>Data type: Rich Text</para></summary>
		[IndexField("body_t")]
		public virtual IRichTextFieldWrapper Body
		{
			get { return GetField<RichTextFieldWrapper>("Body", "body_t"); }
		}

		/// <summary><para>Template: Site Home</para><para>Field: Body</para><para>Data type: Rich Text</para></summary>
		[IndexField("body")]
 		public string BodyValue
		{
			get { return Body.Value; }
		}
		/// <summary><para>Template: Site Home</para><para>Field: Image</para><para>Data type: Image</para></summary>
		public virtual IImageFieldWrapper Image
		{
			get { return GetField<ImageFieldWrapper>("Image"); }
		}

		/// <summary><para>Template: Site Home</para><para>Field: Image</para><para>Data type: Image</para></summary>
 		public string ImageValue
		{
			get { return Image.Value; }
		}
	
	}
}
#endregion
