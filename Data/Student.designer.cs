﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.17929
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace StudentInfoSystem.Data
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="StudentInfoDatabase")]
	public partial class StudentDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertStudent(Student instance);
    partial void UpdateStudent(Student instance);
    partial void DeleteStudent(Student instance);
    #endregion
		
		public StudentDataContext() : 
				base(global::StudentInfoSystem.Properties.Settings.Default.StudentInfoDatabaseConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public StudentDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public StudentDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public StudentDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public StudentDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Student> Students
		{
			get
			{
				return this.GetTable<Student>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Students")]
	public partial class Student : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID;
		
		private string _FirstName;
		
		private string _SecondName;
		
		private string _LastName;
		
		private string _Faculty;
		
		private string _Specialty;
		
		private System.Nullable<short> _OKS;
		
		private System.Nullable<short> _StudentStatus;
		
		private string _FakNumber;
		
		private System.Nullable<short> _Course;
		
		private string _Potok;
		
		private System.Nullable<int> _Group;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnFirstNameChanging(string value);
    partial void OnFirstNameChanged();
    partial void OnSecondNameChanging(string value);
    partial void OnSecondNameChanged();
    partial void OnLastNameChanging(string value);
    partial void OnLastNameChanged();
    partial void OnFacultyChanging(string value);
    partial void OnFacultyChanged();
    partial void OnSpecialtyChanging(string value);
    partial void OnSpecialtyChanged();
    partial void OnOKSChanging(System.Nullable<short> value);
    partial void OnOKSChanged();
    partial void OnStudentStatusChanging(System.Nullable<short> value);
    partial void OnStudentStatusChanged();
    partial void OnFakNumberChanging(string value);
    partial void OnFakNumberChanged();
    partial void OnCourseChanging(System.Nullable<short> value);
    partial void OnCourseChanged();
    partial void OnPotokChanging(string value);
    partial void OnPotokChanged();
    partial void OnGroupChanging(System.Nullable<int> value);
    partial void OnGroupChanged();
    #endregion
		
		public Student()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._ID = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FirstName", DbType="NVarChar(20)")]
		public string FirstName
		{
			get
			{
				return this._FirstName;
			}
			set
			{
				if ((this._FirstName != value))
				{
					this.OnFirstNameChanging(value);
					this.SendPropertyChanging();
					this._FirstName = value;
					this.SendPropertyChanged("FirstName");
					this.OnFirstNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SecondName", DbType="NVarChar(20)")]
		public string SecondName
		{
			get
			{
				return this._SecondName;
			}
			set
			{
				if ((this._SecondName != value))
				{
					this.OnSecondNameChanging(value);
					this.SendPropertyChanging();
					this._SecondName = value;
					this.SendPropertyChanged("SecondName");
					this.OnSecondNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LastName", DbType="NVarChar(20)")]
		public string LastName
		{
			get
			{
				return this._LastName;
			}
			set
			{
				if ((this._LastName != value))
				{
					this.OnLastNameChanging(value);
					this.SendPropertyChanging();
					this._LastName = value;
					this.SendPropertyChanged("LastName");
					this.OnLastNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Faculty", DbType="NVarChar(10)")]
		public string Faculty
		{
			get
			{
				return this._Faculty;
			}
			set
			{
				if ((this._Faculty != value))
				{
					this.OnFacultyChanging(value);
					this.SendPropertyChanging();
					this._Faculty = value;
					this.SendPropertyChanged("Faculty");
					this.OnFacultyChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Specialty", DbType="NVarChar(50)")]
		public string Specialty
		{
			get
			{
				return this._Specialty;
			}
			set
			{
				if ((this._Specialty != value))
				{
					this.OnSpecialtyChanging(value);
					this.SendPropertyChanging();
					this._Specialty = value;
					this.SendPropertyChanged("Specialty");
					this.OnSpecialtyChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_OKS", DbType="SmallInt")]
		public System.Nullable<short> OKS
		{
			get
			{
				return this._OKS;
			}
			set
			{
				if ((this._OKS != value))
				{
					this.OnOKSChanging(value);
					this.SendPropertyChanging();
					this._OKS = value;
					this.SendPropertyChanged("OKS");
					this.OnOKSChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_StudentStatus", DbType="SmallInt")]
		public System.Nullable<short> StudentStatus
		{
			get
			{
				return this._StudentStatus;
			}
			set
			{
				if ((this._StudentStatus != value))
				{
					this.OnStudentStatusChanging(value);
					this.SendPropertyChanging();
					this._StudentStatus = value;
					this.SendPropertyChanged("StudentStatus");
					this.OnStudentStatusChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FakNumber", DbType="NVarChar(50)")]
		public string FakNumber
		{
			get
			{
				return this._FakNumber;
			}
			set
			{
				if ((this._FakNumber != value))
				{
					this.OnFakNumberChanging(value);
					this.SendPropertyChanging();
					this._FakNumber = value;
					this.SendPropertyChanged("FakNumber");
					this.OnFakNumberChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Course", DbType="SmallInt")]
		public System.Nullable<short> Course
		{
			get
			{
				return this._Course;
			}
			set
			{
				if ((this._Course != value))
				{
					this.OnCourseChanging(value);
					this.SendPropertyChanging();
					this._Course = value;
					this.SendPropertyChanged("Course");
					this.OnCourseChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Potok", DbType="NVarChar(5)")]
		public string Potok
		{
			get
			{
				return this._Potok;
			}
			set
			{
				if ((this._Potok != value))
				{
					this.OnPotokChanging(value);
					this.SendPropertyChanging();
					this._Potok = value;
					this.SendPropertyChanged("Potok");
					this.OnPotokChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[Group]", Storage="_Group", DbType="Int")]
		public System.Nullable<int> Group
		{
			get
			{
				return this._Group;
			}
			set
			{
				if ((this._Group != value))
				{
					this.OnGroupChanging(value);
					this.SendPropertyChanging();
					this._Group = value;
					this.SendPropertyChanged("Group");
					this.OnGroupChanged();
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
