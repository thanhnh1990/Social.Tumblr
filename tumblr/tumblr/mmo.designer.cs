﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace tumblr
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="Money")]
	public partial class mmoDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertCategory(Category instance);
    partial void UpdateCategory(Category instance);
    partial void DeleteCategory(Category instance);
    partial void InsertSource(Source instance);
    partial void UpdateSource(Source instance);
    partial void DeleteSource(Source instance);
    partial void InsertPinterest(Pinterest instance);
    partial void UpdatePinterest(Pinterest instance);
    partial void DeletePinterest(Pinterest instance);
    partial void InsertPosting(Posting instance);
    partial void UpdatePosting(Posting instance);
    partial void DeletePosting(Posting instance);
    partial void InsertReachBoardPinterest(ReachBoardPinterest instance);
    partial void UpdateReachBoardPinterest(ReachBoardPinterest instance);
    partial void DeleteReachBoardPinterest(ReachBoardPinterest instance);
    #endregion
		
		public mmoDataContext() : 
				base(global::tumblr.Properties.Settings.Default.MoneyConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public mmoDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public mmoDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public mmoDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public mmoDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Category> Categories
		{
			get
			{
				return this.GetTable<Category>();
			}
		}
		
		public System.Data.Linq.Table<Source> Sources
		{
			get
			{
				return this.GetTable<Source>();
			}
		}
		
		public System.Data.Linq.Table<Pinterest> Pinterests
		{
			get
			{
				return this.GetTable<Pinterest>();
			}
		}
		
		public System.Data.Linq.Table<Posting> Postings
		{
			get
			{
				return this.GetTable<Posting>();
			}
		}
		
		public System.Data.Linq.Table<ReachBoardPinterest> ReachBoardPinterests
		{
			get
			{
				return this.GetTable<ReachBoardPinterest>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Category")]
	public partial class Category : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private System.Nullable<int> _Site_Id;
		
		private System.Nullable<int> _Id_Source;
		
		private System.Nullable<int> _IsParent;
		
		private System.Nullable<int> _Parent_Id;
		
		private string _Name;
		
		private string _Slug;
		
		private string _Description;
		
		private string _Image;
		
		private System.Nullable<int> _IsActive;
		
		private System.Nullable<int> _LoadType;
		
		private EntitySet<Category> _Categories;
		
		private EntityRef<Category> _Category1;
		
		private EntityRef<Source> _Source;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnSite_IdChanging(System.Nullable<int> value);
    partial void OnSite_IdChanged();
    partial void OnId_SourceChanging(System.Nullable<int> value);
    partial void OnId_SourceChanged();
    partial void OnIsParentChanging(System.Nullable<int> value);
    partial void OnIsParentChanged();
    partial void OnParent_IdChanging(System.Nullable<int> value);
    partial void OnParent_IdChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    partial void OnSlugChanging(string value);
    partial void OnSlugChanged();
    partial void OnDescriptionChanging(string value);
    partial void OnDescriptionChanged();
    partial void OnImageChanging(string value);
    partial void OnImageChanged();
    partial void OnIsActiveChanging(System.Nullable<int> value);
    partial void OnIsActiveChanged();
    partial void OnLoadTypeChanging(System.Nullable<int> value);
    partial void OnLoadTypeChanged();
    #endregion
		
		public Category()
		{
			this._Categories = new EntitySet<Category>(new Action<Category>(this.attach_Categories), new Action<Category>(this.detach_Categories));
			this._Category1 = default(EntityRef<Category>);
			this._Source = default(EntityRef<Source>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Site_Id", DbType="Int")]
		public System.Nullable<int> Site_Id
		{
			get
			{
				return this._Site_Id;
			}
			set
			{
				if ((this._Site_Id != value))
				{
					this.OnSite_IdChanging(value);
					this.SendPropertyChanging();
					this._Site_Id = value;
					this.SendPropertyChanged("Site_Id");
					this.OnSite_IdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id_Source", DbType="Int")]
		public System.Nullable<int> Id_Source
		{
			get
			{
				return this._Id_Source;
			}
			set
			{
				if ((this._Id_Source != value))
				{
					if (this._Source.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnId_SourceChanging(value);
					this.SendPropertyChanging();
					this._Id_Source = value;
					this.SendPropertyChanged("Id_Source");
					this.OnId_SourceChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IsParent", DbType="Int")]
		public System.Nullable<int> IsParent
		{
			get
			{
				return this._IsParent;
			}
			set
			{
				if ((this._IsParent != value))
				{
					this.OnIsParentChanging(value);
					this.SendPropertyChanging();
					this._IsParent = value;
					this.SendPropertyChanged("IsParent");
					this.OnIsParentChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Parent_Id", DbType="Int")]
		public System.Nullable<int> Parent_Id
		{
			get
			{
				return this._Parent_Id;
			}
			set
			{
				if ((this._Parent_Id != value))
				{
					if (this._Category1.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnParent_IdChanging(value);
					this.SendPropertyChanging();
					this._Parent_Id = value;
					this.SendPropertyChanged("Parent_Id");
					this.OnParent_IdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="NVarChar(50)")]
		public string Name
		{
			get
			{
				return this._Name;
			}
			set
			{
				if ((this._Name != value))
				{
					this.OnNameChanging(value);
					this.SendPropertyChanging();
					this._Name = value;
					this.SendPropertyChanged("Name");
					this.OnNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Slug", DbType="NVarChar(500)")]
		public string Slug
		{
			get
			{
				return this._Slug;
			}
			set
			{
				if ((this._Slug != value))
				{
					this.OnSlugChanging(value);
					this.SendPropertyChanging();
					this._Slug = value;
					this.SendPropertyChanged("Slug");
					this.OnSlugChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Description", DbType="NVarChar(500)")]
		public string Description
		{
			get
			{
				return this._Description;
			}
			set
			{
				if ((this._Description != value))
				{
					this.OnDescriptionChanging(value);
					this.SendPropertyChanging();
					this._Description = value;
					this.SendPropertyChanged("Description");
					this.OnDescriptionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Image", DbType="NVarChar(500)")]
		public string Image
		{
			get
			{
				return this._Image;
			}
			set
			{
				if ((this._Image != value))
				{
					this.OnImageChanging(value);
					this.SendPropertyChanging();
					this._Image = value;
					this.SendPropertyChanged("Image");
					this.OnImageChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IsActive", DbType="Int")]
		public System.Nullable<int> IsActive
		{
			get
			{
				return this._IsActive;
			}
			set
			{
				if ((this._IsActive != value))
				{
					this.OnIsActiveChanging(value);
					this.SendPropertyChanging();
					this._IsActive = value;
					this.SendPropertyChanged("IsActive");
					this.OnIsActiveChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LoadType", DbType="Int")]
		public System.Nullable<int> LoadType
		{
			get
			{
				return this._LoadType;
			}
			set
			{
				if ((this._LoadType != value))
				{
					this.OnLoadTypeChanging(value);
					this.SendPropertyChanging();
					this._LoadType = value;
					this.SendPropertyChanged("LoadType");
					this.OnLoadTypeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Category_Category", Storage="_Categories", ThisKey="Id", OtherKey="Parent_Id")]
		public EntitySet<Category> Categories
		{
			get
			{
				return this._Categories;
			}
			set
			{
				this._Categories.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Category_Category", Storage="_Category1", ThisKey="Parent_Id", OtherKey="Id", IsForeignKey=true)]
		public Category Category1
		{
			get
			{
				return this._Category1.Entity;
			}
			set
			{
				Category previousValue = this._Category1.Entity;
				if (((previousValue != value) 
							|| (this._Category1.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Category1.Entity = null;
						previousValue.Categories.Remove(this);
					}
					this._Category1.Entity = value;
					if ((value != null))
					{
						value.Categories.Add(this);
						this._Parent_Id = value.Id;
					}
					else
					{
						this._Parent_Id = default(Nullable<int>);
					}
					this.SendPropertyChanged("Category1");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Source_Category", Storage="_Source", ThisKey="Id_Source", OtherKey="Id", IsForeignKey=true)]
		public Source Source
		{
			get
			{
				return this._Source.Entity;
			}
			set
			{
				Source previousValue = this._Source.Entity;
				if (((previousValue != value) 
							|| (this._Source.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Source.Entity = null;
						previousValue.Categories.Remove(this);
					}
					this._Source.Entity = value;
					if ((value != null))
					{
						value.Categories.Add(this);
						this._Id_Source = value.Id;
					}
					else
					{
						this._Id_Source = default(Nullable<int>);
					}
					this.SendPropertyChanged("Source");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_Categories(Category entity)
		{
			this.SendPropertyChanging();
			entity.Category1 = this;
		}
		
		private void detach_Categories(Category entity)
		{
			this.SendPropertyChanging();
			entity.Category1 = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Sources")]
	public partial class Source : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _Site;
		
		private string _Name;
		
		private string _Domain;
		
		private int _IsActive;
		
		private EntitySet<Category> _Categories;
		
		private EntitySet<Posting> _Postings;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnSiteChanging(string value);
    partial void OnSiteChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    partial void OnDomainChanging(string value);
    partial void OnDomainChanged();
    partial void OnIsActiveChanging(int value);
    partial void OnIsActiveChanged();
    #endregion
		
		public Source()
		{
			this._Categories = new EntitySet<Category>(new Action<Category>(this.attach_Categories), new Action<Category>(this.detach_Categories));
			this._Postings = new EntitySet<Posting>(new Action<Posting>(this.attach_Postings), new Action<Posting>(this.detach_Postings));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Site", DbType="NVarChar(50)")]
		public string Site
		{
			get
			{
				return this._Site;
			}
			set
			{
				if ((this._Site != value))
				{
					this.OnSiteChanging(value);
					this.SendPropertyChanging();
					this._Site = value;
					this.SendPropertyChanged("Site");
					this.OnSiteChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string Name
		{
			get
			{
				return this._Name;
			}
			set
			{
				if ((this._Name != value))
				{
					this.OnNameChanging(value);
					this.SendPropertyChanging();
					this._Name = value;
					this.SendPropertyChanged("Name");
					this.OnNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Domain", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string Domain
		{
			get
			{
				return this._Domain;
			}
			set
			{
				if ((this._Domain != value))
				{
					this.OnDomainChanging(value);
					this.SendPropertyChanging();
					this._Domain = value;
					this.SendPropertyChanged("Domain");
					this.OnDomainChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IsActive", DbType="Int NOT NULL")]
		public int IsActive
		{
			get
			{
				return this._IsActive;
			}
			set
			{
				if ((this._IsActive != value))
				{
					this.OnIsActiveChanging(value);
					this.SendPropertyChanging();
					this._IsActive = value;
					this.SendPropertyChanged("IsActive");
					this.OnIsActiveChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Source_Category", Storage="_Categories", ThisKey="Id", OtherKey="Id_Source")]
		public EntitySet<Category> Categories
		{
			get
			{
				return this._Categories;
			}
			set
			{
				this._Categories.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Source_Posting", Storage="_Postings", ThisKey="Id", OtherKey="SourceId")]
		public EntitySet<Posting> Postings
		{
			get
			{
				return this._Postings;
			}
			set
			{
				this._Postings.Assign(value);
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_Categories(Category entity)
		{
			this.SendPropertyChanging();
			entity.Source = this;
		}
		
		private void detach_Categories(Category entity)
		{
			this.SendPropertyChanging();
			entity.Source = null;
		}
		
		private void attach_Postings(Posting entity)
		{
			this.SendPropertyChanging();
			entity.Source = this;
		}
		
		private void detach_Postings(Posting entity)
		{
			this.SendPropertyChanging();
			entity.Source = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Pinterest")]
	public partial class Pinterest : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _PinId;
		
		private string _Old_Id;
		
		private string _Board;
		
		private string _Backlink;
		
		private string _Note;
		
		private string _Image_Url;
		
		private System.Nullable<int> _Type;
		
		private System.Nullable<int> _Is_Pin;
		
		private System.DateTime _Created_Date;
		
		private System.Nullable<System.DateTime> _Update_Date;
		
		private EntitySet<Posting> _Postings;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnPinIdChanging(string value);
    partial void OnPinIdChanged();
    partial void OnOld_IdChanging(string value);
    partial void OnOld_IdChanged();
    partial void OnBoardChanging(string value);
    partial void OnBoardChanged();
    partial void OnBacklinkChanging(string value);
    partial void OnBacklinkChanged();
    partial void OnNoteChanging(string value);
    partial void OnNoteChanged();
    partial void OnImage_UrlChanging(string value);
    partial void OnImage_UrlChanged();
    partial void OnTypeChanging(System.Nullable<int> value);
    partial void OnTypeChanged();
    partial void OnIs_PinChanging(System.Nullable<int> value);
    partial void OnIs_PinChanged();
    partial void OnCreated_DateChanging(System.DateTime value);
    partial void OnCreated_DateChanged();
    partial void OnUpdate_DateChanging(System.Nullable<System.DateTime> value);
    partial void OnUpdate_DateChanged();
    #endregion
		
		public Pinterest()
		{
			this._Postings = new EntitySet<Posting>(new Action<Posting>(this.attach_Postings), new Action<Posting>(this.detach_Postings));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PinId", DbType="NVarChar(50)")]
		public string PinId
		{
			get
			{
				return this._PinId;
			}
			set
			{
				if ((this._PinId != value))
				{
					this.OnPinIdChanging(value);
					this.SendPropertyChanging();
					this._PinId = value;
					this.SendPropertyChanged("PinId");
					this.OnPinIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Old_Id", DbType="NVarChar(50)")]
		public string Old_Id
		{
			get
			{
				return this._Old_Id;
			}
			set
			{
				if ((this._Old_Id != value))
				{
					this.OnOld_IdChanging(value);
					this.SendPropertyChanging();
					this._Old_Id = value;
					this.SendPropertyChanged("Old_Id");
					this.OnOld_IdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Board", DbType="NVarChar(100)")]
		public string Board
		{
			get
			{
				return this._Board;
			}
			set
			{
				if ((this._Board != value))
				{
					this.OnBoardChanging(value);
					this.SendPropertyChanging();
					this._Board = value;
					this.SendPropertyChanged("Board");
					this.OnBoardChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Backlink", DbType="NVarChar(500)")]
		public string Backlink
		{
			get
			{
				return this._Backlink;
			}
			set
			{
				if ((this._Backlink != value))
				{
					this.OnBacklinkChanging(value);
					this.SendPropertyChanging();
					this._Backlink = value;
					this.SendPropertyChanged("Backlink");
					this.OnBacklinkChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Note", DbType="NVarChar(1000)")]
		public string Note
		{
			get
			{
				return this._Note;
			}
			set
			{
				if ((this._Note != value))
				{
					this.OnNoteChanging(value);
					this.SendPropertyChanging();
					this._Note = value;
					this.SendPropertyChanged("Note");
					this.OnNoteChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Image_Url", DbType="NVarChar(500)")]
		public string Image_Url
		{
			get
			{
				return this._Image_Url;
			}
			set
			{
				if ((this._Image_Url != value))
				{
					this.OnImage_UrlChanging(value);
					this.SendPropertyChanging();
					this._Image_Url = value;
					this.SendPropertyChanged("Image_Url");
					this.OnImage_UrlChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Type", DbType="Int")]
		public System.Nullable<int> Type
		{
			get
			{
				return this._Type;
			}
			set
			{
				if ((this._Type != value))
				{
					this.OnTypeChanging(value);
					this.SendPropertyChanging();
					this._Type = value;
					this.SendPropertyChanged("Type");
					this.OnTypeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Is_Pin", DbType="Int")]
		public System.Nullable<int> Is_Pin
		{
			get
			{
				return this._Is_Pin;
			}
			set
			{
				if ((this._Is_Pin != value))
				{
					this.OnIs_PinChanging(value);
					this.SendPropertyChanging();
					this._Is_Pin = value;
					this.SendPropertyChanged("Is_Pin");
					this.OnIs_PinChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Created_Date", DbType="DateTime NOT NULL")]
		public System.DateTime Created_Date
		{
			get
			{
				return this._Created_Date;
			}
			set
			{
				if ((this._Created_Date != value))
				{
					this.OnCreated_DateChanging(value);
					this.SendPropertyChanging();
					this._Created_Date = value;
					this.SendPropertyChanged("Created_Date");
					this.OnCreated_DateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Update_Date", DbType="DateTime")]
		public System.Nullable<System.DateTime> Update_Date
		{
			get
			{
				return this._Update_Date;
			}
			set
			{
				if ((this._Update_Date != value))
				{
					this.OnUpdate_DateChanging(value);
					this.SendPropertyChanging();
					this._Update_Date = value;
					this.SendPropertyChanged("Update_Date");
					this.OnUpdate_DateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Pinterest_Posting", Storage="_Postings", ThisKey="Id", OtherKey="ImgId")]
		public EntitySet<Posting> Postings
		{
			get
			{
				return this._Postings;
			}
			set
			{
				this._Postings.Assign(value);
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_Postings(Posting entity)
		{
			this.SendPropertyChanging();
			entity.Pinterest = this;
		}
		
		private void detach_Postings(Posting entity)
		{
			this.SendPropertyChanging();
			entity.Pinterest = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Posting")]
	public partial class Posting : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private long _Id;
		
		private System.Nullable<int> _ImgId;
		
		private System.Nullable<int> _SourceId;
		
		private EntityRef<Pinterest> _Pinterest;
		
		private EntityRef<Source> _Source;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(long value);
    partial void OnIdChanged();
    partial void OnImgIdChanging(System.Nullable<int> value);
    partial void OnImgIdChanged();
    partial void OnSourceIdChanging(System.Nullable<int> value);
    partial void OnSourceIdChanged();
    #endregion
		
		public Posting()
		{
			this._Pinterest = default(EntityRef<Pinterest>);
			this._Source = default(EntityRef<Source>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="BigInt NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public long Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ImgId", DbType="Int")]
		public System.Nullable<int> ImgId
		{
			get
			{
				return this._ImgId;
			}
			set
			{
				if ((this._ImgId != value))
				{
					if (this._Pinterest.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnImgIdChanging(value);
					this.SendPropertyChanging();
					this._ImgId = value;
					this.SendPropertyChanged("ImgId");
					this.OnImgIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SourceId", DbType="Int")]
		public System.Nullable<int> SourceId
		{
			get
			{
				return this._SourceId;
			}
			set
			{
				if ((this._SourceId != value))
				{
					if (this._Source.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnSourceIdChanging(value);
					this.SendPropertyChanging();
					this._SourceId = value;
					this.SendPropertyChanged("SourceId");
					this.OnSourceIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Pinterest_Posting", Storage="_Pinterest", ThisKey="ImgId", OtherKey="Id", IsForeignKey=true)]
		public Pinterest Pinterest
		{
			get
			{
				return this._Pinterest.Entity;
			}
			set
			{
				Pinterest previousValue = this._Pinterest.Entity;
				if (((previousValue != value) 
							|| (this._Pinterest.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Pinterest.Entity = null;
						previousValue.Postings.Remove(this);
					}
					this._Pinterest.Entity = value;
					if ((value != null))
					{
						value.Postings.Add(this);
						this._ImgId = value.Id;
					}
					else
					{
						this._ImgId = default(Nullable<int>);
					}
					this.SendPropertyChanged("Pinterest");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Source_Posting", Storage="_Source", ThisKey="SourceId", OtherKey="Id", IsForeignKey=true)]
		public Source Source
		{
			get
			{
				return this._Source.Entity;
			}
			set
			{
				Source previousValue = this._Source.Entity;
				if (((previousValue != value) 
							|| (this._Source.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Source.Entity = null;
						previousValue.Postings.Remove(this);
					}
					this._Source.Entity = value;
					if ((value != null))
					{
						value.Postings.Add(this);
						this._SourceId = value.Id;
					}
					else
					{
						this._SourceId = default(Nullable<int>);
					}
					this.SendPropertyChanged("Source");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.ReachBoardPinterest")]
	public partial class ReachBoardPinterest : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _Board;
		
		private string _Category;
		
		private System.Nullable<int> _IsLoad;
		
		private System.Nullable<int> _Total_Page;
		
		private System.Nullable<int> _IsDone;
		
		private string _NextPage;
		
		private System.Nullable<System.DateTime> _CreateDate;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnBoardChanging(string value);
    partial void OnBoardChanged();
    partial void OnCategoryChanging(string value);
    partial void OnCategoryChanged();
    partial void OnIsLoadChanging(System.Nullable<int> value);
    partial void OnIsLoadChanged();
    partial void OnTotal_PageChanging(System.Nullable<int> value);
    partial void OnTotal_PageChanged();
    partial void OnIsDoneChanging(System.Nullable<int> value);
    partial void OnIsDoneChanged();
    partial void OnNextPageChanging(string value);
    partial void OnNextPageChanged();
    partial void OnCreateDateChanging(System.Nullable<System.DateTime> value);
    partial void OnCreateDateChanged();
    #endregion
		
		public ReachBoardPinterest()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Board", DbType="NVarChar(500)")]
		public string Board
		{
			get
			{
				return this._Board;
			}
			set
			{
				if ((this._Board != value))
				{
					this.OnBoardChanging(value);
					this.SendPropertyChanging();
					this._Board = value;
					this.SendPropertyChanged("Board");
					this.OnBoardChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Category", DbType="NVarChar(50)")]
		public string Category
		{
			get
			{
				return this._Category;
			}
			set
			{
				if ((this._Category != value))
				{
					this.OnCategoryChanging(value);
					this.SendPropertyChanging();
					this._Category = value;
					this.SendPropertyChanged("Category");
					this.OnCategoryChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IsLoad", DbType="Int")]
		public System.Nullable<int> IsLoad
		{
			get
			{
				return this._IsLoad;
			}
			set
			{
				if ((this._IsLoad != value))
				{
					this.OnIsLoadChanging(value);
					this.SendPropertyChanging();
					this._IsLoad = value;
					this.SendPropertyChanged("IsLoad");
					this.OnIsLoadChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Total_Page", DbType="Int")]
		public System.Nullable<int> Total_Page
		{
			get
			{
				return this._Total_Page;
			}
			set
			{
				if ((this._Total_Page != value))
				{
					this.OnTotal_PageChanging(value);
					this.SendPropertyChanging();
					this._Total_Page = value;
					this.SendPropertyChanged("Total_Page");
					this.OnTotal_PageChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IsDone", DbType="Int")]
		public System.Nullable<int> IsDone
		{
			get
			{
				return this._IsDone;
			}
			set
			{
				if ((this._IsDone != value))
				{
					this.OnIsDoneChanging(value);
					this.SendPropertyChanging();
					this._IsDone = value;
					this.SendPropertyChanged("IsDone");
					this.OnIsDoneChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NextPage", DbType="NVarChar(1000)")]
		public string NextPage
		{
			get
			{
				return this._NextPage;
			}
			set
			{
				if ((this._NextPage != value))
				{
					this.OnNextPageChanging(value);
					this.SendPropertyChanging();
					this._NextPage = value;
					this.SendPropertyChanged("NextPage");
					this.OnNextPageChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CreateDate", DbType="DateTime")]
		public System.Nullable<System.DateTime> CreateDate
		{
			get
			{
				return this._CreateDate;
			}
			set
			{
				if ((this._CreateDate != value))
				{
					this.OnCreateDateChanging(value);
					this.SendPropertyChanging();
					this._CreateDate = value;
					this.SendPropertyChanged("CreateDate");
					this.OnCreateDateChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
}
#pragma warning restore 1591
