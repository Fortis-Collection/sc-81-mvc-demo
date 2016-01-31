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
	public partial interface IContent : ICustomItemWrapper , Demo.Model.Templates.UserDefined.IDemoStandardTemplate, Demo.Model.Templates.UserDefined.IContentTitle, Demo.Model.Templates.UserDefined.IContentBody, Demo.Model.Templates.UserDefined.IContentImage
	{		
	}

	/// <summary>
	/// <para>Template class</para><para>/sitecore/templates/User Defined/Generic/Content Chunks/Content</para>
	/// </summary>
	[PredefinedQuery("TemplateId", ComparisonType.Equal, "{0AD237CA-46E3-4F3E-A57F-C6F796F0CF0C}", typeof(Guid))]
	[TemplateMapping("{0AD237CA-46E3-4F3E-A57F-C6F796F0CF0C}", "")]
	public partial class Content : CustomItemWrapper, IContent
	{
		private Item _item = null;

		public Content(ISpawnProvider spawnProvider) : base(null, spawnProvider) { }

		public Content(Guid id, ISpawnProvider spawnProvider) : base(id, spawnProvider) { }

		public Content(Guid id, Dictionary<string, object> lazyFields, ISpawnProvider spawnProvider) : base(id, lazyFields, spawnProvider) { }

		public Content(Item item, ISpawnProvider spawnProvider) : base(item, spawnProvider)
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
	public partial interface IDemoStandardTemplate : ICustomItemWrapper 
	{		
	}

	/// <summary>
	/// <para>Template class</para><para>/sitecore/templates/User Defined/Demo Standard Template</para>
	/// </summary>
	[PredefinedQuery("TemplateId", ComparisonType.Equal, "{147A11EF-8721-4211-8D27-776E2B02A2AC}", typeof(Guid))]
	[TemplateMapping("{147A11EF-8721-4211-8D27-776E2B02A2AC}", "")]
	public partial class DemoStandardTemplate : CustomItemWrapper, IDemoStandardTemplate
	{
		private Item _item = null;

		public DemoStandardTemplate(ISpawnProvider spawnProvider) : base(null, spawnProvider) { }

		public DemoStandardTemplate(Guid id, ISpawnProvider spawnProvider) : base(id, spawnProvider) { }

		public DemoStandardTemplate(Guid id, Dictionary<string, object> lazyFields, ISpawnProvider spawnProvider) : base(id, lazyFields, spawnProvider) { }

		public DemoStandardTemplate(Item item, ISpawnProvider spawnProvider) : base(item, spawnProvider)
		{
			_item = item;
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
	public partial interface IPage : ICustomItemWrapper , Demo.Model.Templates.UserDefined.IDemoStandardTemplate, Demo.Model.Templates.UserDefined.IContent
	{		
	}

	/// <summary>
	/// <para>Template class</para><para>/sitecore/templates/User Defined/Generic/Page</para>
	/// </summary>
	[PredefinedQuery("TemplateId", ComparisonType.Equal, "{5E874F90-6493-4994-9C83-4C8A93347506}", typeof(Guid))]
	[TemplateMapping("{5E874F90-6493-4994-9C83-4C8A93347506}", "")]
	public partial class Page : CustomItemWrapper, IPage
	{
		private Item _item = null;

		public Page(ISpawnProvider spawnProvider) : base(null, spawnProvider) { }

		public Page(Guid id, ISpawnProvider spawnProvider) : base(id, spawnProvider) { }

		public Page(Guid id, Dictionary<string, object> lazyFields, ISpawnProvider spawnProvider) : base(id, lazyFields, spawnProvider) { }

		public Page(Item item, ISpawnProvider spawnProvider) : base(item, spawnProvider)
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
	public partial interface IContentBody : ICustomItemWrapper , Demo.Model.Templates.UserDefined.IDemoStandardTemplate
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
	public partial class ContentBody : CustomItemWrapper, IContentBody
	{
		private Item _item = null;

		public ContentBody(ISpawnProvider spawnProvider) : base(null, spawnProvider) { }

		public ContentBody(Guid id, ISpawnProvider spawnProvider) : base(id, spawnProvider) { }

		public ContentBody(Guid id, Dictionary<string, object> lazyFields, ISpawnProvider spawnProvider) : base(id, lazyFields, spawnProvider) { }

		public ContentBody(Item item, ISpawnProvider spawnProvider) : base(item, spawnProvider)
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
	public partial interface IGeneralPage : ICustomItemWrapper , Demo.Model.Templates.UserDefined.IDemoStandardTemplate, Demo.Model.Templates.UserDefined.IPage
	{		
	}

	/// <summary>
	/// <para>Template class</para><para>/sitecore/templates/User Defined/Generic/General Page</para>
	/// </summary>
	[PredefinedQuery("TemplateId", ComparisonType.Equal, "{79589439-529E-412D-9B9C-8D2B3751F424}", typeof(Guid))]
	[TemplateMapping("{79589439-529E-412D-9B9C-8D2B3751F424}", "")]
	public partial class GeneralPage : CustomItemWrapper, IGeneralPage
	{
		private Item _item = null;

		public GeneralPage(ISpawnProvider spawnProvider) : base(null, spawnProvider) { }

		public GeneralPage(Guid id, ISpawnProvider spawnProvider) : base(id, spawnProvider) { }

		public GeneralPage(Guid id, Dictionary<string, object> lazyFields, ISpawnProvider spawnProvider) : base(id, lazyFields, spawnProvider) { }

		public GeneralPage(Item item, ISpawnProvider spawnProvider) : base(item, spawnProvider)
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
	public partial interface IDemoStandardRenderingParameters : IRenderingParameterWrapper 
	{		
	}

	/// <summary>
	/// <para>Template class</para><para>/sitecore/templates/User Defined/Demo Standard Rendering Parameters</para>
	/// </summary>
	[PredefinedQuery("TemplateId", ComparisonType.Equal, "{8B64EBB3-0C3E-488C-A34A-1369FA2E8C36}", typeof(Guid))]
	[TemplateMapping("{8B64EBB3-0C3E-488C-A34A-1369FA2E8C36}", "RenderingParameter")]
	public partial class DemoStandardRenderingParameters : RenderingParameterWrapper, IDemoStandardRenderingParameters
	{
		public DemoStandardRenderingParameters(Dictionary<string, string> parameters, ISpawnProvider spawnProvider) : base(parameters, spawnProvider)
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
	public partial interface IContentImage : ICustomItemWrapper , Demo.Model.Templates.UserDefined.IDemoStandardTemplate
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
	public partial class ContentImage : CustomItemWrapper, IContentImage
	{
		private Item _item = null;

		public ContentImage(ISpawnProvider spawnProvider) : base(null, spawnProvider) { }

		public ContentImage(Guid id, ISpawnProvider spawnProvider) : base(id, spawnProvider) { }

		public ContentImage(Guid id, Dictionary<string, object> lazyFields, ISpawnProvider spawnProvider) : base(id, lazyFields, spawnProvider) { }

		public ContentImage(Item item, ISpawnProvider spawnProvider) : base(item, spawnProvider)
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
	public partial interface IContentTitle : ICustomItemWrapper , Demo.Model.Templates.UserDefined.IDemoStandardTemplate
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
	public partial class ContentTitle : CustomItemWrapper, IContentTitle
	{
		private Item _item = null;

		public ContentTitle(ISpawnProvider spawnProvider) : base(null, spawnProvider) { }

		public ContentTitle(Guid id, ISpawnProvider spawnProvider) : base(id, spawnProvider) { }

		public ContentTitle(Guid id, Dictionary<string, object> lazyFields, ISpawnProvider spawnProvider) : base(id, lazyFields, spawnProvider) { }

		public ContentTitle(Item item, ISpawnProvider spawnProvider) : base(item, spawnProvider)
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
	public partial interface ISiteRoot : ICustomItemWrapper , Demo.Model.Templates.UserDefined.IDemoStandardTemplate
	{		
	}

	/// <summary>
	/// <para>Template class</para><para>/sitecore/templates/User Defined/Site/Site Root</para>
	/// </summary>
	[PredefinedQuery("TemplateId", ComparisonType.Equal, "{F5B5DCF2-703B-450D-A800-DFACB52E8BE2}", typeof(Guid))]
	[TemplateMapping("{F5B5DCF2-703B-450D-A800-DFACB52E8BE2}", "")]
	public partial class SiteRoot : CustomItemWrapper, ISiteRoot
	{
		private Item _item = null;

		public SiteRoot(ISpawnProvider spawnProvider) : base(null, spawnProvider) { }

		public SiteRoot(Guid id, ISpawnProvider spawnProvider) : base(id, spawnProvider) { }

		public SiteRoot(Guid id, Dictionary<string, object> lazyFields, ISpawnProvider spawnProvider) : base(id, lazyFields, spawnProvider) { }

		public SiteRoot(Item item, ISpawnProvider spawnProvider) : base(item, spawnProvider)
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
	public partial interface ISiteHome : ICustomItemWrapper , Demo.Model.Templates.UserDefined.IDemoStandardTemplate, Demo.Model.Templates.UserDefined.IPage
	{		
	}

	/// <summary>
	/// <para>Template class</para><para>/sitecore/templates/User Defined/Site/Site Home</para>
	/// </summary>
	[PredefinedQuery("TemplateId", ComparisonType.Equal, "{FF55701A-0F87-482E-A66F-6D1EB75CAEA3}", typeof(Guid))]
	[TemplateMapping("{FF55701A-0F87-482E-A66F-6D1EB75CAEA3}", "")]
	public partial class SiteHome : CustomItemWrapper, ISiteHome
	{
		private Item _item = null;

		public SiteHome(ISpawnProvider spawnProvider) : base(null, spawnProvider) { }

		public SiteHome(Guid id, ISpawnProvider spawnProvider) : base(id, spawnProvider) { }

		public SiteHome(Guid id, Dictionary<string, object> lazyFields, ISpawnProvider spawnProvider) : base(id, lazyFields, spawnProvider) { }

		public SiteHome(Item item, ISpawnProvider spawnProvider) : base(item, spawnProvider)
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
