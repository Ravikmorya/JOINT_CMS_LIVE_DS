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

[assembly: RegisterDocumentType(Services.CLASS_NAME, typeof(Services))]

namespace CMS.DocumentEngine.Types.DotStark
{
	/// <summary>
	/// Represents a content item of type Services.
	/// </summary>
	public partial class Services : TreeNode
	{
		#region "Constants and variables"

		/// <summary>
		/// The name of the data class.
		/// </summary>
		public const string CLASS_NAME = "DotStark.Services";


		/// <summary>
		/// The instance of the class that provides extended API for working with Services fields.
		/// </summary>
		private readonly ServicesFields mFields;

		#endregion


		#region "Properties"

		/// <summary>
		/// ServicesID.
		/// </summary>
		[DatabaseIDField]
		public int ServicesID
		{
			get
			{
				return ValidationHelper.GetInteger(GetValue("ServicesID"), 0);
			}
			set
			{
				SetValue("ServicesID", value);
			}
		}


		/// <summary>
		/// Name.
		/// </summary>
		[DatabaseField]
		public string ServicesName
		{
			get
			{
				return ValidationHelper.GetString(GetValue("ServicesName"), @"");
			}
			set
			{
				SetValue("ServicesName", value);
			}
		}


		/// <summary>
		/// Gets an object that provides extended API for working with Services fields.
		/// </summary>
		[RegisterProperty]
		public ServicesFields Fields
		{
			get
			{
				return mFields;
			}
		}


		/// <summary>
		/// Provides extended API for working with Services fields.
		/// </summary>
		[RegisterAllProperties]
		public partial class ServicesFields : AbstractHierarchicalObject<ServicesFields>
		{
			/// <summary>
			/// The content item of type Services that is a target of the extended API.
			/// </summary>
			private readonly Services mInstance;


			/// <summary>
			/// Initializes a new instance of the <see cref="ServicesFields" /> class with the specified content item of type Services.
			/// </summary>
			/// <param name="instance">The content item of type Services that is a target of the extended API.</param>
			public ServicesFields(Services instance)
			{
				mInstance = instance;
			}


			/// <summary>
			/// ServicesID.
			/// </summary>
			public int ID
			{
				get
				{
					return mInstance.ServicesID;
				}
				set
				{
					mInstance.ServicesID = value;
				}
			}


			/// <summary>
			/// Name.
			/// </summary>
			public string Name
			{
				get
				{
					return mInstance.ServicesName;
				}
				set
				{
					mInstance.ServicesName = value;
				}
			}
		}

		#endregion


		#region "Constructors"

		/// <summary>
		/// Initializes a new instance of the <see cref="Services" /> class.
		/// </summary>
		public Services() : base(CLASS_NAME)
		{
			mFields = new ServicesFields(this);
		}

		#endregion
	}
}