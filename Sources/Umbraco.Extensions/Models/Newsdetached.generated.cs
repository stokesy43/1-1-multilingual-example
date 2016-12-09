//------------------------------------------------------------------------------
// <auto-generated>
//   This code was generated by a tool.
//
//    Umbraco.ModelsBuilder v3.0.5.96
//
//   Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Web;
using Umbraco.Core.Models;
using Umbraco.Core.Models.PublishedContent;
using Umbraco.Web;
using Umbraco.ModelsBuilder;
using Umbraco.ModelsBuilder.Umbraco;

namespace Umbraco.Extensions.Models
{
	/// <summary>NewsDetached</summary>
	[PublishedContentModel("Newsdetached")]
	public partial class Newsdetached : Detached
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "Newsdetached";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public Newsdetached(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Newsdetached, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Text
		///</summary>
		[ImplementPropertyType("bodyText")]
		public IHtmlString BodyText
		{
			get { return this.GetPropertyValue<IHtmlString>("bodyText"); }
		}

		///<summary>
		/// Media
		///</summary>
		[ImplementPropertyType("media")]
		public string Media
		{
			get { return this.GetPropertyValue<string>("media"); }
		}

		///<summary>
		/// Subheader
		///</summary>
		[ImplementPropertyType("subheader")]
		public string Subheader
		{
			get { return this.GetPropertyValue<string>("subheader"); }
		}
	}
}
