﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18444
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MedSCANLibrary
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="MedSCAN_DB")]
	public partial class DataClasses1DataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertPatient(Patient instance);
    partial void UpdatePatient(Patient instance);
    partial void DeletePatient(Patient instance);
    #endregion
		
		public DataClasses1DataContext() : 
				base(global::MedSCANLibrary.Properties.Settings.Default.MedSCAN_DBConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Patient> Patients
		{
			get
			{
				return this.GetTable<Patient>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Patient")]
	public partial class Patient : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _PatientID;
		
		private string _firstname;
		
		private string _lastname;
		
		private System.Nullable<char> _middleInit;
		
		private char _gender;
		
		private System.Nullable<char> _pregnant;
		
		private System.Nullable<System.DateTime> _DOB;
		
		private System.Data.Linq.Binary _photo;
		
		private string _allergies;
		
		private string _scheduledMed_IDs;
		
		private string _PRNMed_IDS;
		
		private string _physician;
		
		private string _comments;
		
		private bool _status;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnPatientIDChanging(int value);
    partial void OnPatientIDChanged();
    partial void OnfirstnameChanging(string value);
    partial void OnfirstnameChanged();
    partial void OnlastnameChanging(string value);
    partial void OnlastnameChanged();
    partial void OnmiddleInitChanging(System.Nullable<char> value);
    partial void OnmiddleInitChanged();
    partial void OngenderChanging(char value);
    partial void OngenderChanged();
    partial void OnpregnantChanging(System.Nullable<char> value);
    partial void OnpregnantChanged();
    partial void OnDOBChanging(System.Nullable<System.DateTime> value);
    partial void OnDOBChanged();
    partial void OnphotoChanging(System.Data.Linq.Binary value);
    partial void OnphotoChanged();
    partial void OnallergiesChanging(string value);
    partial void OnallergiesChanged();
    partial void OnscheduledMed_IDsChanging(string value);
    partial void OnscheduledMed_IDsChanged();
    partial void OnPRNMed_IDSChanging(string value);
    partial void OnPRNMed_IDSChanged();
    partial void OnphysicianChanging(string value);
    partial void OnphysicianChanged();
    partial void OncommentsChanging(string value);
    partial void OncommentsChanged();
    partial void OnstatusChanging(bool value);
    partial void OnstatusChanged();
    #endregion
		
		public Patient()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PatientID", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int PatientID
		{
			get
			{
				return this._PatientID;
			}
			set
			{
				if ((this._PatientID != value))
				{
					this.OnPatientIDChanging(value);
					this.SendPropertyChanging();
					this._PatientID = value;
					this.SendPropertyChanged("PatientID");
					this.OnPatientIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_firstname", DbType="NVarChar(50)")]
		public string firstname
		{
			get
			{
				return this._firstname;
			}
			set
			{
				if ((this._firstname != value))
				{
					this.OnfirstnameChanging(value);
					this.SendPropertyChanging();
					this._firstname = value;
					this.SendPropertyChanged("firstname");
					this.OnfirstnameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_lastname", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string lastname
		{
			get
			{
				return this._lastname;
			}
			set
			{
				if ((this._lastname != value))
				{
					this.OnlastnameChanging(value);
					this.SendPropertyChanging();
					this._lastname = value;
					this.SendPropertyChanged("lastname");
					this.OnlastnameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_middleInit", DbType="NChar(1)")]
		public System.Nullable<char> middleInit
		{
			get
			{
				return this._middleInit;
			}
			set
			{
				if ((this._middleInit != value))
				{
					this.OnmiddleInitChanging(value);
					this.SendPropertyChanging();
					this._middleInit = value;
					this.SendPropertyChanged("middleInit");
					this.OnmiddleInitChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_gender", DbType="NChar(1) NOT NULL")]
		public char gender
		{
			get
			{
				return this._gender;
			}
			set
			{
				if ((this._gender != value))
				{
					this.OngenderChanging(value);
					this.SendPropertyChanging();
					this._gender = value;
					this.SendPropertyChanged("gender");
					this.OngenderChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_pregnant", DbType="NChar(1)")]
		public System.Nullable<char> pregnant
		{
			get
			{
				return this._pregnant;
			}
			set
			{
				if ((this._pregnant != value))
				{
					this.OnpregnantChanging(value);
					this.SendPropertyChanging();
					this._pregnant = value;
					this.SendPropertyChanged("pregnant");
					this.OnpregnantChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DOB", DbType="Date")]
		public System.Nullable<System.DateTime> DOB
		{
			get
			{
				return this._DOB;
			}
			set
			{
				if ((this._DOB != value))
				{
					this.OnDOBChanging(value);
					this.SendPropertyChanging();
					this._DOB = value;
					this.SendPropertyChanged("DOB");
					this.OnDOBChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_photo", DbType="Image", CanBeNull=true, UpdateCheck=UpdateCheck.Never)]
		public System.Data.Linq.Binary photo
		{
			get
			{
				return this._photo;
			}
			set
			{
				if ((this._photo != value))
				{
					this.OnphotoChanging(value);
					this.SendPropertyChanging();
					this._photo = value;
					this.SendPropertyChanged("photo");
					this.OnphotoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_allergies", DbType="NVarChar(256)")]
		public string allergies
		{
			get
			{
				return this._allergies;
			}
			set
			{
				if ((this._allergies != value))
				{
					this.OnallergiesChanging(value);
					this.SendPropertyChanging();
					this._allergies = value;
					this.SendPropertyChanged("allergies");
					this.OnallergiesChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_scheduledMed_IDs", DbType="NVarChar(MAX)")]
		public string scheduledMed_IDs
		{
			get
			{
				return this._scheduledMed_IDs;
			}
			set
			{
				if ((this._scheduledMed_IDs != value))
				{
					this.OnscheduledMed_IDsChanging(value);
					this.SendPropertyChanging();
					this._scheduledMed_IDs = value;
					this.SendPropertyChanged("scheduledMed_IDs");
					this.OnscheduledMed_IDsChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PRNMed_IDS", DbType="NVarChar(MAX)")]
		public string PRNMed_IDS
		{
			get
			{
				return this._PRNMed_IDS;
			}
			set
			{
				if ((this._PRNMed_IDS != value))
				{
					this.OnPRNMed_IDSChanging(value);
					this.SendPropertyChanging();
					this._PRNMed_IDS = value;
					this.SendPropertyChanged("PRNMed_IDS");
					this.OnPRNMed_IDSChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_physician", DbType="NVarChar(50)")]
		public string physician
		{
			get
			{
				return this._physician;
			}
			set
			{
				if ((this._physician != value))
				{
					this.OnphysicianChanging(value);
					this.SendPropertyChanging();
					this._physician = value;
					this.SendPropertyChanged("physician");
					this.OnphysicianChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_comments", DbType="NVarChar(512)")]
		public string comments
		{
			get
			{
				return this._comments;
			}
			set
			{
				if ((this._comments != value))
				{
					this.OncommentsChanging(value);
					this.SendPropertyChanging();
					this._comments = value;
					this.SendPropertyChanged("comments");
					this.OncommentsChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_status", DbType="Bit NOT NULL")]
		public bool status
		{
			get
			{
				return this._status;
			}
			set
			{
				if ((this._status != value))
				{
					this.OnstatusChanging(value);
					this.SendPropertyChanging();
					this._status = value;
					this.SendPropertyChanged("status");
					this.OnstatusChanged();
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
