//--------------------------------------------------------------------------------------------------
// <auto-generated>
//
//     This code was generated by code generator tool.
//
//     To customize the code use your own partial class. For more info about how to use and customize
//     the generated code see the documentation at http://docs.kentico.com.
//
// </auto-generated>
//--------------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;

using CMS;
using CMS.Base;
using CMS.Helpers;
using CMS.DataEngine;
using CMS.DocumentEngine.Types.DotStark;
using CMS.DocumentEngine;

[assembly: RegisterDocumentType(HomeEx.CLASS_NAME, typeof(HomeEx))]

namespace CMS.DocumentEngine.Types.DotStark
{
	/// <summary>
	/// Represents a content item of type HomeEx.
	/// </summary>
	public partial class HomeEx : TreeNode
	{
		#region "Constants and variables"

		/// <summary>
		/// The name of the data class.
		/// </summary>
		public const string CLASS_NAME = "DotStark.HomeEx";


		/// <summary>
		/// The instance of the class that provides extended API for working with HomeEx fields.
		/// </summary>
		private readonly HomeExFields mFields;

		#endregion


		#region "Properties"

		/// <summary>
		/// HomeExID.
		/// </summary>
		[DatabaseIDField]
		public int HomeExID
		{
			get
			{
				return ValidationHelper.GetInteger(GetValue("HomeExID"), 0);
			}
			set
			{
				SetValue("HomeExID", value);
			}
		}


		/// <summary>
		/// Name.
		/// </summary>
		[DatabaseField]
		public string Name
		{
			get
			{
				return ValidationHelper.GetString(GetValue("Name"), @"");
			}
			set
			{
				SetValue("Name", value);
			}
		}


		/// <summary>
		/// Gets an object that provides extended API for working with HomeEx fields.
		/// </summary>
		[RegisterProperty]
		public HomeExFields Fields
		{
			get
			{
				return mFields;
			}
		}


		/// <summary>
		/// Provides extended API for working with HomeEx fields.
		/// </summary>
		[RegisterAllProperties]
		public partial class HomeExFields : AbstractHierarchicalObject<HomeExFields>
		{
			/// <summary>
			/// The content item of type HomeEx that is a target of the extended API.
			/// </summary>
			private readonly HomeEx mInstance;


			/// <summary>
			/// Initializes a new instance of the <see cref="HomeExFields" /> class with the specified content item of type HomeEx.
			/// </summary>
			/// <param name="instance">The content item of type HomeEx that is a target of the extended API.</param>
			public HomeExFields(HomeEx instance)
			{
				mInstance = instance;
			}


			/// <summary>
			/// HomeExID.
			/// </summary>
			public int ID
			{
				get
				{
					return mInstance.HomeExID;
				}
				set
				{
					mInstance.HomeExID = value;
				}
			}


			/// <summary>
			/// Name.
			/// </summary>
			public string Name
			{
				get
				{
					return mInstance.Name;
				}
				set
				{
					mInstance.Name = value;
				}
			}
		}

		#endregion


		#region "Constructors"

		/// <summary>
		/// Initializes a new instance of the <see cref="HomeEx" /> class.
		/// </summary>
		public HomeEx() : base(CLASS_NAME)
		{
			mFields = new HomeExFields(this);
		}

		#endregion
	}
}