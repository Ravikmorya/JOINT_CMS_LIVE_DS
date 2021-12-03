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

[assembly: RegisterDocumentType(ServicesSection.CLASS_NAME, typeof(ServicesSection))]

namespace CMS.DocumentEngine.Types.DotStark
{
	/// <summary>
	/// Represents a content item of type ServicesSection.
	/// </summary>
	public partial class ServicesSection : TreeNode
	{
		#region "Constants and variables"

		/// <summary>
		/// The name of the data class.
		/// </summary>
		public const string CLASS_NAME = "DotStark.ServicesSection";


		/// <summary>
		/// The instance of the class that provides extended API for working with ServicesSection fields.
		/// </summary>
		private readonly ServicesSectionFields mFields;

		#endregion


		#region "Properties"

		/// <summary>
		/// ServicesSectionID.
		/// </summary>
		[DatabaseIDField]
		public int ServicesSectionID
		{
			get
			{
				return ValidationHelper.GetInteger(GetValue("ServicesSectionID"), 0);
			}
			set
			{
				SetValue("ServicesSectionID", value);
			}
		}


		/// <summary>
		/// Text1.
		/// </summary>
		[DatabaseField]
		public string ServicesSectionText1
		{
			get
			{
				return ValidationHelper.GetString(GetValue("ServicesSectionText1"), @"");
			}
			set
			{
				SetValue("ServicesSectionText1", value);
			}
		}


		/// <summary>
		/// TextImage.
		/// </summary>
		[DatabaseField]
		public Guid ServicesSectionTextImage
		{
			get
			{
				return ValidationHelper.GetGuid(GetValue("ServicesSectionTextImage"), Guid.Empty);
			}
			set
			{
				SetValue("ServicesSectionTextImage", value);
			}
		}


		/// <summary>
		/// TextImage1.
		/// </summary>
		[DatabaseField]
		public Guid ServicesSectionTextImage1
		{
			get
			{
				return ValidationHelper.GetGuid(GetValue("ServicesSectionTextImage1"), Guid.Empty);
			}
			set
			{
				SetValue("ServicesSectionTextImage1", value);
			}
		}


		/// <summary>
		/// Text2.
		/// </summary>
		[DatabaseField]
		public string ServicesSectionText2
		{
			get
			{
				return ValidationHelper.GetString(GetValue("ServicesSectionText2"), @"");
			}
			set
			{
				SetValue("ServicesSectionText2", value);
			}
		}


		/// <summary>
		/// TextImage2.
		/// </summary>
		[DatabaseField]
		public Guid ServicesSectionTextImage2
		{
			get
			{
				return ValidationHelper.GetGuid(GetValue("ServicesSectionTextImage2"), Guid.Empty);
			}
			set
			{
				SetValue("ServicesSectionTextImage2", value);
			}
		}


		/// <summary>
		/// Text3.
		/// </summary>
		[DatabaseField]
		public string ServicesSectionText3
		{
			get
			{
				return ValidationHelper.GetString(GetValue("ServicesSectionText3"), @"");
			}
			set
			{
				SetValue("ServicesSectionText3", value);
			}
		}


		/// <summary>
		/// TextImage3.
		/// </summary>
		[DatabaseField]
		public Guid ServicesSectionTextImage3
		{
			get
			{
				return ValidationHelper.GetGuid(GetValue("ServicesSectionTextImage3"), Guid.Empty);
			}
			set
			{
				SetValue("ServicesSectionTextImage3", value);
			}
		}


		/// <summary>
		/// Text4.
		/// </summary>
		[DatabaseField]
		public string ServicesSectionText4
		{
			get
			{
				return ValidationHelper.GetString(GetValue("ServicesSectionText4"), @"");
			}
			set
			{
				SetValue("ServicesSectionText4", value);
			}
		}


		/// <summary>
		/// TextImage4.
		/// </summary>
		[DatabaseField]
		public Guid ServicesSectionTextImage4
		{
			get
			{
				return ValidationHelper.GetGuid(GetValue("ServicesSectionTextImage4"), Guid.Empty);
			}
			set
			{
				SetValue("ServicesSectionTextImage4", value);
			}
		}


		/// <summary>
		/// Text5.
		/// </summary>
		[DatabaseField]
		public string ServicesSectionText5
		{
			get
			{
				return ValidationHelper.GetString(GetValue("ServicesSectionText5"), @"");
			}
			set
			{
				SetValue("ServicesSectionText5", value);
			}
		}


		/// <summary>
		/// TextImage5.
		/// </summary>
		[DatabaseField]
		public Guid ServicesSectionTextImage5
		{
			get
			{
				return ValidationHelper.GetGuid(GetValue("ServicesSectionTextImage5"), Guid.Empty);
			}
			set
			{
				SetValue("ServicesSectionTextImage5", value);
			}
		}


		/// <summary>
		/// Text6.
		/// </summary>
		[DatabaseField]
		public string ServicesSectionText6
		{
			get
			{
				return ValidationHelper.GetString(GetValue("ServicesSectionText6"), @"");
			}
			set
			{
				SetValue("ServicesSectionText6", value);
			}
		}


		/// <summary>
		/// TextImage6.
		/// </summary>
		[DatabaseField]
		public Guid ServicesSectionTextImage6
		{
			get
			{
				return ValidationHelper.GetGuid(GetValue("ServicesSectionTextImage6"), Guid.Empty);
			}
			set
			{
				SetValue("ServicesSectionTextImage6", value);
			}
		}


		/// <summary>
		/// Gets an object that provides extended API for working with ServicesSection fields.
		/// </summary>
		[RegisterProperty]
		public ServicesSectionFields Fields
		{
			get
			{
				return mFields;
			}
		}


		/// <summary>
		/// Provides extended API for working with ServicesSection fields.
		/// </summary>
		[RegisterAllProperties]
		public partial class ServicesSectionFields : AbstractHierarchicalObject<ServicesSectionFields>
		{
			/// <summary>
			/// The content item of type ServicesSection that is a target of the extended API.
			/// </summary>
			private readonly ServicesSection mInstance;


			/// <summary>
			/// Initializes a new instance of the <see cref="ServicesSectionFields" /> class with the specified content item of type ServicesSection.
			/// </summary>
			/// <param name="instance">The content item of type ServicesSection that is a target of the extended API.</param>
			public ServicesSectionFields(ServicesSection instance)
			{
				mInstance = instance;
			}


			/// <summary>
			/// ServicesSectionID.
			/// </summary>
			public int ID
			{
				get
				{
					return mInstance.ServicesSectionID;
				}
				set
				{
					mInstance.ServicesSectionID = value;
				}
			}


			/// <summary>
			/// Text1.
			/// </summary>
			public string Text1
			{
				get
				{
					return mInstance.ServicesSectionText1;
				}
				set
				{
					mInstance.ServicesSectionText1 = value;
				}
			}


			/// <summary>
			/// TextImage.
			/// </summary>
			public DocumentAttachment TextImage
			{
				get
				{
					return mInstance.GetFieldDocumentAttachment("ServicesSectionTextImage");
				}
			}


			/// <summary>
			/// TextImage1.
			/// </summary>
			public DocumentAttachment TextImage1
			{
				get
				{
					return mInstance.GetFieldDocumentAttachment("ServicesSectionTextImage1");
				}
			}


			/// <summary>
			/// Text2.
			/// </summary>
			public string Text2
			{
				get
				{
					return mInstance.ServicesSectionText2;
				}
				set
				{
					mInstance.ServicesSectionText2 = value;
				}
			}


			/// <summary>
			/// TextImage2.
			/// </summary>
			public DocumentAttachment TextImage2
			{
				get
				{
					return mInstance.GetFieldDocumentAttachment("ServicesSectionTextImage2");
				}
			}


			/// <summary>
			/// Text3.
			/// </summary>
			public string Text3
			{
				get
				{
					return mInstance.ServicesSectionText3;
				}
				set
				{
					mInstance.ServicesSectionText3 = value;
				}
			}


			/// <summary>
			/// TextImage3.
			/// </summary>
			public DocumentAttachment TextImage3
			{
				get
				{
					return mInstance.GetFieldDocumentAttachment("ServicesSectionTextImage3");
				}
			}


			/// <summary>
			/// Text4.
			/// </summary>
			public string Text4
			{
				get
				{
					return mInstance.ServicesSectionText4;
				}
				set
				{
					mInstance.ServicesSectionText4 = value;
				}
			}


			/// <summary>
			/// TextImage4.
			/// </summary>
			public DocumentAttachment TextImage4
			{
				get
				{
					return mInstance.GetFieldDocumentAttachment("ServicesSectionTextImage4");
				}
			}


			/// <summary>
			/// Text5.
			/// </summary>
			public string Text5
			{
				get
				{
					return mInstance.ServicesSectionText5;
				}
				set
				{
					mInstance.ServicesSectionText5 = value;
				}
			}


			/// <summary>
			/// TextImage5.
			/// </summary>
			public DocumentAttachment TextImage5
			{
				get
				{
					return mInstance.GetFieldDocumentAttachment("ServicesSectionTextImage5");
				}
			}


			/// <summary>
			/// Text6.
			/// </summary>
			public string Text6
			{
				get
				{
					return mInstance.ServicesSectionText6;
				}
				set
				{
					mInstance.ServicesSectionText6 = value;
				}
			}


			/// <summary>
			/// TextImage6.
			/// </summary>
			public DocumentAttachment TextImage6
			{
				get
				{
					return mInstance.GetFieldDocumentAttachment("ServicesSectionTextImage6");
				}
			}
		}

		#endregion


		#region "Constructors"

		/// <summary>
		/// Initializes a new instance of the <see cref="ServicesSection" /> class.
		/// </summary>
		public ServicesSection() : base(CLASS_NAME)
		{
			mFields = new ServicesSectionFields(this);
		}

		#endregion
	}
}