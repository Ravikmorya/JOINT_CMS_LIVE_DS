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

[assembly: RegisterDocumentType(StrengthsSection.CLASS_NAME, typeof(StrengthsSection))]

namespace CMS.DocumentEngine.Types.DotStark
{
	/// <summary>
	/// Represents a content item of type StrengthsSection.
	/// </summary>
	public partial class StrengthsSection : TreeNode
	{
		#region "Constants and variables"

		/// <summary>
		/// The name of the data class.
		/// </summary>
		public const string CLASS_NAME = "DotStark.StrengthsSection";


		/// <summary>
		/// The instance of the class that provides extended API for working with StrengthsSection fields.
		/// </summary>
		private readonly StrengthsSectionFields mFields;

		#endregion


		#region "Properties"

		/// <summary>
		/// StrengthsSectionID.
		/// </summary>
		[DatabaseIDField]
		public int StrengthsSectionID
		{
			get
			{
				return ValidationHelper.GetInteger(GetValue("StrengthsSectionID"), 0);
			}
			set
			{
				SetValue("StrengthsSectionID", value);
			}
		}


		/// <summary>
		/// Heading.
		/// </summary>
		[DatabaseField]
		public string StrengthsHeading
		{
			get
			{
				return ValidationHelper.GetString(GetValue("StrengthsHeading"), @"");
			}
			set
			{
				SetValue("StrengthsHeading", value);
			}
		}


		/// <summary>
		/// Heading1.
		/// </summary>
		[DatabaseField]
		public string StrengthsHeading1
		{
			get
			{
				return ValidationHelper.GetString(GetValue("StrengthsHeading1"), @"");
			}
			set
			{
				SetValue("StrengthsHeading1", value);
			}
		}


		/// <summary>
		/// File.
		/// </summary>
		[DatabaseField]
		public Guid StrengthsFile
		{
			get
			{
				return ValidationHelper.GetGuid(GetValue("StrengthsFile"), Guid.Empty);
			}
			set
			{
				SetValue("StrengthsFile", value);
			}
		}


		/// <summary>
		/// Text.
		/// </summary>
		[DatabaseField]
		public string StrengthsText
		{
			get
			{
				return ValidationHelper.GetString(GetValue("StrengthsText"), @"");
			}
			set
			{
				SetValue("StrengthsText", value);
			}
		}


		/// <summary>
		/// Gets an object that provides extended API for working with StrengthsSection fields.
		/// </summary>
		[RegisterProperty]
		public StrengthsSectionFields Fields
		{
			get
			{
				return mFields;
			}
		}


		/// <summary>
		/// Provides extended API for working with StrengthsSection fields.
		/// </summary>
		[RegisterAllProperties]
		public partial class StrengthsSectionFields : AbstractHierarchicalObject<StrengthsSectionFields>
		{
			/// <summary>
			/// The content item of type StrengthsSection that is a target of the extended API.
			/// </summary>
			private readonly StrengthsSection mInstance;


			/// <summary>
			/// Initializes a new instance of the <see cref="StrengthsSectionFields" /> class with the specified content item of type StrengthsSection.
			/// </summary>
			/// <param name="instance">The content item of type StrengthsSection that is a target of the extended API.</param>
			public StrengthsSectionFields(StrengthsSection instance)
			{
				mInstance = instance;
			}


			/// <summary>
			/// StrengthsSectionID.
			/// </summary>
			public int ID
			{
				get
				{
					return mInstance.StrengthsSectionID;
				}
				set
				{
					mInstance.StrengthsSectionID = value;
				}
			}


			/// <summary>
			/// Heading.
			/// </summary>
			public string StrengthsHeading
			{
				get
				{
					return mInstance.StrengthsHeading;
				}
				set
				{
					mInstance.StrengthsHeading = value;
				}
			}


			/// <summary>
			/// Heading1.
			/// </summary>
			public string StrengthsHeading1
			{
				get
				{
					return mInstance.StrengthsHeading1;
				}
				set
				{
					mInstance.StrengthsHeading1 = value;
				}
			}


			/// <summary>
			/// File.
			/// </summary>
			public DocumentAttachment StrengthsFile
			{
				get
				{
					return mInstance.GetFieldDocumentAttachment("StrengthsFile");
				}
			}


			/// <summary>
			/// Text.
			/// </summary>
			public string StrengthsText
			{
				get
				{
					return mInstance.StrengthsText;
				}
				set
				{
					mInstance.StrengthsText = value;
				}
			}
		}

		#endregion


		#region "Constructors"

		/// <summary>
		/// Initializes a new instance of the <see cref="StrengthsSection" /> class.
		/// </summary>
		public StrengthsSection() : base(CLASS_NAME)
		{
			mFields = new StrengthsSectionFields(this);
		}

		#endregion
	}
}