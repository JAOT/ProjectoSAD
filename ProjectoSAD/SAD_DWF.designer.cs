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

namespace ProjectoSAD
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="sad_dwf")]
	public partial class SAD_DWFDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void Insertuser(user instance);
    partial void Updateuser(user instance);
    partial void Deleteuser(user instance);
    partial void Inserttype(type instance);
    partial void Updatetype(type instance);
    partial void Deletetype(type instance);
    partial void Insertstudent(student instance);
    partial void Updatestudent(student instance);
    partial void Deletestudent(student instance);
    #endregion
		
		public SAD_DWFDataContext() : 
				base(global::ProjectoSAD.Properties.Settings.Default.sad_dwfConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public SAD_DWFDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public SAD_DWFDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public SAD_DWFDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public SAD_DWFDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<user> users
		{
			get
			{
				return this.GetTable<user>();
			}
		}
		
		public System.Data.Linq.Table<type> types
		{
			get
			{
				return this.GetTable<type>();
			}
		}
		
		public System.Data.Linq.Table<student> students
		{
			get
			{
				return this.GetTable<student>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.users")]
	public partial class user : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private long _id;
		
		private long _type_id;
		
		private string _fname;
		
		private string _lname;
		
		private string _phone;
		
		private string _email;
		
		private System.DateTime _email_verified_at;
		
		private string _password;
		
		private System.DateTime _password_changed_at;
		
		private byte _active;
		
		private string _timezone;
		
		private System.DateTime _last_login_at;
		
		private byte _to_be_logged_out;
		
		private string _remember_token;
		
		private System.DateTime _created_at;
		
		private System.DateTime _updated_at;
		
		private EntityRef<type> _type;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidChanging(long value);
    partial void OnidChanged();
    partial void Ontype_idChanging(long value);
    partial void Ontype_idChanged();
    partial void OnfnameChanging(string value);
    partial void OnfnameChanged();
    partial void OnlnameChanging(string value);
    partial void OnlnameChanged();
    partial void OnphoneChanging(string value);
    partial void OnphoneChanged();
    partial void OnemailChanging(string value);
    partial void OnemailChanged();
    partial void Onemail_verified_atChanging(System.DateTime value);
    partial void Onemail_verified_atChanged();
    partial void OnpasswordChanging(string value);
    partial void OnpasswordChanged();
    partial void Onpassword_changed_atChanging(System.DateTime value);
    partial void Onpassword_changed_atChanged();
    partial void OnactiveChanging(byte value);
    partial void OnactiveChanged();
    partial void OntimezoneChanging(string value);
    partial void OntimezoneChanged();
    partial void Onlast_login_atChanging(System.DateTime value);
    partial void Onlast_login_atChanged();
    partial void Onto_be_logged_outChanging(byte value);
    partial void Onto_be_logged_outChanged();
    partial void Onremember_tokenChanging(string value);
    partial void Onremember_tokenChanged();
    partial void Oncreated_atChanging(System.DateTime value);
    partial void Oncreated_atChanged();
    partial void Onupdated_atChanging(System.DateTime value);
    partial void Onupdated_atChanged();
    #endregion
		
		public user()
		{
			this._type = default(EntityRef<type>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id", AutoSync=AutoSync.OnInsert, DbType="BigInt NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public long id
		{
			get
			{
				return this._id;
			}
			set
			{
				if ((this._id != value))
				{
					this.OnidChanging(value);
					this.SendPropertyChanging();
					this._id = value;
					this.SendPropertyChanged("id");
					this.OnidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_type_id", DbType="BigInt NOT NULL")]
		public long type_id
		{
			get
			{
				return this._type_id;
			}
			set
			{
				if ((this._type_id != value))
				{
					if (this._type.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.Ontype_idChanging(value);
					this.SendPropertyChanging();
					this._type_id = value;
					this.SendPropertyChanged("type_id");
					this.Ontype_idChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_fname", DbType="VarChar(191) NOT NULL", CanBeNull=false)]
		public string fname
		{
			get
			{
				return this._fname;
			}
			set
			{
				if ((this._fname != value))
				{
					this.OnfnameChanging(value);
					this.SendPropertyChanging();
					this._fname = value;
					this.SendPropertyChanged("fname");
					this.OnfnameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_lname", DbType="VarChar(191) NOT NULL", CanBeNull=false)]
		public string lname
		{
			get
			{
				return this._lname;
			}
			set
			{
				if ((this._lname != value))
				{
					this.OnlnameChanging(value);
					this.SendPropertyChanging();
					this._lname = value;
					this.SendPropertyChanged("lname");
					this.OnlnameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_phone", DbType="VarChar(191) NOT NULL", CanBeNull=false)]
		public string phone
		{
			get
			{
				return this._phone;
			}
			set
			{
				if ((this._phone != value))
				{
					this.OnphoneChanging(value);
					this.SendPropertyChanging();
					this._phone = value;
					this.SendPropertyChanged("phone");
					this.OnphoneChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_email", DbType="VarChar(191) NOT NULL", CanBeNull=false)]
		public string email
		{
			get
			{
				return this._email;
			}
			set
			{
				if ((this._email != value))
				{
					this.OnemailChanging(value);
					this.SendPropertyChanging();
					this._email = value;
					this.SendPropertyChanged("email");
					this.OnemailChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_email_verified_at", DbType="DateTime NOT NULL")]
		public System.DateTime email_verified_at
		{
			get
			{
				return this._email_verified_at;
			}
			set
			{
				if ((this._email_verified_at != value))
				{
					this.Onemail_verified_atChanging(value);
					this.SendPropertyChanging();
					this._email_verified_at = value;
					this.SendPropertyChanged("email_verified_at");
					this.Onemail_verified_atChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_password", DbType="VarChar(191) NOT NULL", CanBeNull=false)]
		public string password
		{
			get
			{
				return this._password;
			}
			set
			{
				if ((this._password != value))
				{
					this.OnpasswordChanging(value);
					this.SendPropertyChanging();
					this._password = value;
					this.SendPropertyChanged("password");
					this.OnpasswordChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_password_changed_at", DbType="DateTime NOT NULL")]
		public System.DateTime password_changed_at
		{
			get
			{
				return this._password_changed_at;
			}
			set
			{
				if ((this._password_changed_at != value))
				{
					this.Onpassword_changed_atChanging(value);
					this.SendPropertyChanging();
					this._password_changed_at = value;
					this.SendPropertyChanged("password_changed_at");
					this.Onpassword_changed_atChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_active", DbType="TinyInt NOT NULL")]
		public byte active
		{
			get
			{
				return this._active;
			}
			set
			{
				if ((this._active != value))
				{
					this.OnactiveChanging(value);
					this.SendPropertyChanging();
					this._active = value;
					this.SendPropertyChanged("active");
					this.OnactiveChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_timezone", DbType="VarChar(191) NOT NULL", CanBeNull=false)]
		public string timezone
		{
			get
			{
				return this._timezone;
			}
			set
			{
				if ((this._timezone != value))
				{
					this.OntimezoneChanging(value);
					this.SendPropertyChanging();
					this._timezone = value;
					this.SendPropertyChanged("timezone");
					this.OntimezoneChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_last_login_at", DbType="DateTime NOT NULL")]
		public System.DateTime last_login_at
		{
			get
			{
				return this._last_login_at;
			}
			set
			{
				if ((this._last_login_at != value))
				{
					this.Onlast_login_atChanging(value);
					this.SendPropertyChanging();
					this._last_login_at = value;
					this.SendPropertyChanged("last_login_at");
					this.Onlast_login_atChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_to_be_logged_out", DbType="TinyInt NOT NULL")]
		public byte to_be_logged_out
		{
			get
			{
				return this._to_be_logged_out;
			}
			set
			{
				if ((this._to_be_logged_out != value))
				{
					this.Onto_be_logged_outChanging(value);
					this.SendPropertyChanging();
					this._to_be_logged_out = value;
					this.SendPropertyChanged("to_be_logged_out");
					this.Onto_be_logged_outChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_remember_token", DbType="VarChar(191) NOT NULL", CanBeNull=false)]
		public string remember_token
		{
			get
			{
				return this._remember_token;
			}
			set
			{
				if ((this._remember_token != value))
				{
					this.Onremember_tokenChanging(value);
					this.SendPropertyChanging();
					this._remember_token = value;
					this.SendPropertyChanged("remember_token");
					this.Onremember_tokenChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_created_at", DbType="DateTime NOT NULL")]
		public System.DateTime created_at
		{
			get
			{
				return this._created_at;
			}
			set
			{
				if ((this._created_at != value))
				{
					this.Oncreated_atChanging(value);
					this.SendPropertyChanging();
					this._created_at = value;
					this.SendPropertyChanged("created_at");
					this.Oncreated_atChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_updated_at", DbType="DateTime NOT NULL")]
		public System.DateTime updated_at
		{
			get
			{
				return this._updated_at;
			}
			set
			{
				if ((this._updated_at != value))
				{
					this.Onupdated_atChanging(value);
					this.SendPropertyChanging();
					this._updated_at = value;
					this.SendPropertyChanged("updated_at");
					this.Onupdated_atChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="type_user", Storage="_type", ThisKey="type_id", OtherKey="id", IsForeignKey=true)]
		public type type
		{
			get
			{
				return this._type.Entity;
			}
			set
			{
				type previousValue = this._type.Entity;
				if (((previousValue != value) 
							|| (this._type.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._type.Entity = null;
						previousValue.users.Remove(this);
					}
					this._type.Entity = value;
					if ((value != null))
					{
						value.users.Add(this);
						this._type_id = value.id;
					}
					else
					{
						this._type_id = default(long);
					}
					this.SendPropertyChanged("type");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.types")]
	public partial class type : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private long _id;
		
		private string _name;
		
		private byte _active;
		
		private System.DateTime _created_at;
		
		private System.DateTime _updated_at;
		
		private EntitySet<user> _users;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidChanging(long value);
    partial void OnidChanged();
    partial void OnnameChanging(string value);
    partial void OnnameChanged();
    partial void OnactiveChanging(byte value);
    partial void OnactiveChanged();
    partial void Oncreated_atChanging(System.DateTime value);
    partial void Oncreated_atChanged();
    partial void Onupdated_atChanging(System.DateTime value);
    partial void Onupdated_atChanged();
    #endregion
		
		public type()
		{
			this._users = new EntitySet<user>(new Action<user>(this.attach_users), new Action<user>(this.detach_users));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id", DbType="BigInt NOT NULL", IsPrimaryKey=true)]
		public long id
		{
			get
			{
				return this._id;
			}
			set
			{
				if ((this._id != value))
				{
					this.OnidChanging(value);
					this.SendPropertyChanging();
					this._id = value;
					this.SendPropertyChanged("id");
					this.OnidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_name", DbType="VarChar(191) NOT NULL", CanBeNull=false)]
		public string name
		{
			get
			{
				return this._name;
			}
			set
			{
				if ((this._name != value))
				{
					this.OnnameChanging(value);
					this.SendPropertyChanging();
					this._name = value;
					this.SendPropertyChanged("name");
					this.OnnameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_active", DbType="TinyInt NOT NULL")]
		public byte active
		{
			get
			{
				return this._active;
			}
			set
			{
				if ((this._active != value))
				{
					this.OnactiveChanging(value);
					this.SendPropertyChanging();
					this._active = value;
					this.SendPropertyChanged("active");
					this.OnactiveChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_created_at", DbType="DateTime NOT NULL")]
		public System.DateTime created_at
		{
			get
			{
				return this._created_at;
			}
			set
			{
				if ((this._created_at != value))
				{
					this.Oncreated_atChanging(value);
					this.SendPropertyChanging();
					this._created_at = value;
					this.SendPropertyChanged("created_at");
					this.Oncreated_atChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_updated_at", DbType="DateTime NOT NULL")]
		public System.DateTime updated_at
		{
			get
			{
				return this._updated_at;
			}
			set
			{
				if ((this._updated_at != value))
				{
					this.Onupdated_atChanging(value);
					this.SendPropertyChanging();
					this._updated_at = value;
					this.SendPropertyChanged("updated_at");
					this.Onupdated_atChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="type_user", Storage="_users", ThisKey="id", OtherKey="type_id")]
		public EntitySet<user> users
		{
			get
			{
				return this._users;
			}
			set
			{
				this._users.Assign(value);
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
		
		private void attach_users(user entity)
		{
			this.SendPropertyChanging();
			entity.type = this;
		}
		
		private void detach_users(user entity)
		{
			this.SendPropertyChanging();
			entity.type = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.students")]
	public partial class student : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private long _id;
		
		private string _name;
		
		private string _email;
		
		private string _student_number;
		
		private System.Nullable<System.DateTime> _created_at;
		
		private System.Nullable<System.DateTime> _updated_at;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidChanging(long value);
    partial void OnidChanged();
    partial void OnnameChanging(string value);
    partial void OnnameChanged();
    partial void OnemailChanging(string value);
    partial void OnemailChanged();
    partial void Onstudent_numberChanging(string value);
    partial void Onstudent_numberChanged();
    partial void Oncreated_atChanging(System.Nullable<System.DateTime> value);
    partial void Oncreated_atChanged();
    partial void Onupdated_atChanging(System.Nullable<System.DateTime> value);
    partial void Onupdated_atChanged();
    #endregion
		
		public student()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id", AutoSync=AutoSync.OnInsert, DbType="BigInt NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public long id
		{
			get
			{
				return this._id;
			}
			set
			{
				if ((this._id != value))
				{
					this.OnidChanging(value);
					this.SendPropertyChanging();
					this._id = value;
					this.SendPropertyChanged("id");
					this.OnidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_name", DbType="VarChar(191) NOT NULL", CanBeNull=false)]
		public string name
		{
			get
			{
				return this._name;
			}
			set
			{
				if ((this._name != value))
				{
					this.OnnameChanging(value);
					this.SendPropertyChanging();
					this._name = value;
					this.SendPropertyChanged("name");
					this.OnnameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_email", DbType="VarChar(191) NOT NULL", CanBeNull=false)]
		public string email
		{
			get
			{
				return this._email;
			}
			set
			{
				if ((this._email != value))
				{
					this.OnemailChanging(value);
					this.SendPropertyChanging();
					this._email = value;
					this.SendPropertyChanged("email");
					this.OnemailChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_student_number", DbType="VarChar(191) NOT NULL", CanBeNull=false)]
		public string student_number
		{
			get
			{
				return this._student_number;
			}
			set
			{
				if ((this._student_number != value))
				{
					this.Onstudent_numberChanging(value);
					this.SendPropertyChanging();
					this._student_number = value;
					this.SendPropertyChanged("student_number");
					this.Onstudent_numberChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_created_at", DbType="DateTime")]
		public System.Nullable<System.DateTime> created_at
		{
			get
			{
				return this._created_at;
			}
			set
			{
				if ((this._created_at != value))
				{
					this.Oncreated_atChanging(value);
					this.SendPropertyChanging();
					this._created_at = value;
					this.SendPropertyChanged("created_at");
					this.Oncreated_atChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_updated_at", DbType="DateTime")]
		public System.Nullable<System.DateTime> updated_at
		{
			get
			{
				return this._updated_at;
			}
			set
			{
				if ((this._updated_at != value))
				{
					this.Onupdated_atChanging(value);
					this.SendPropertyChanging();
					this._updated_at = value;
					this.SendPropertyChanged("updated_at");
					this.Onupdated_atChanged();
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
