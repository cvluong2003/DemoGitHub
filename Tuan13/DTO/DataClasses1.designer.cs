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

namespace DTO
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="data1")]
	public partial class DataClasses1DataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    #endregion
		
		public DataClasses1DataContext() : 
				base(global::DTO.Properties.Settings.Default.data1ConnectionString, mappingSource)
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
		
		public System.Data.Linq.Table<Sheet1_> Sheet1_s
		{
			get
			{
				return this.GetTable<Sheet1_>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Sheet1$")]
	public partial class Sheet1_
	{
		
		private System.Nullable<double> _stt;
		
		private System.Nullable<double> _mssv_;
		
		private string _tensv;
		
		private System.Nullable<double> _ds_nnlt;
		
		private System.Nullable<double> _ds_th_nnlt;
		
		private System.Nullable<double> _ds_lthdt;
		
		private System.Nullable<double> _ds_th_lthdt;
		
		private System.Nullable<double> _ds_ctdl_gt;
		
		private System.Nullable<double> _ds_th_ctdlgt;
		
		private System.Nullable<double> _ds_csdl;
		
		private System.Nullable<double> _ds_th_csdl;
		
		private System.Nullable<double> _ds_toancc;
		
		private System.Nullable<double> _diemtlhe4;
		
		private System.Nullable<double> _ds_diemtlhe10;
		
		private string _dc_nnlt;
		
		private string _dc_th_nnlt;
		
		private string _dc_lthdt;
		
		private string _dc_th_lthdt;
		
		private string _dc_ctdl_gt;
		
		private string _dc_th_ctdlgt;
		
		private string _dc_csdl;
		
		private string _dc_th_csdl;
		
		private string _dc_toancc;
		
		private string _dc_diemtlhe10;
		
		private string _chuyennganh;
		
		public Sheet1_()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_stt", DbType="Float")]
		public System.Nullable<double> stt
		{
			get
			{
				return this._stt;
			}
			set
			{
				if ((this._stt != value))
				{
					this._stt = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[mssv ]", Storage="_mssv_", DbType="Float")]
		public System.Nullable<double> mssv_
		{
			get
			{
				return this._mssv_;
			}
			set
			{
				if ((this._mssv_ != value))
				{
					this._mssv_ = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_tensv", DbType="NVarChar(255)")]
		public string tensv
		{
			get
			{
				return this._tensv;
			}
			set
			{
				if ((this._tensv != value))
				{
					this._tensv = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ds_nnlt", DbType="Float")]
		public System.Nullable<double> ds_nnlt
		{
			get
			{
				return this._ds_nnlt;
			}
			set
			{
				if ((this._ds_nnlt != value))
				{
					this._ds_nnlt = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ds_th_nnlt", DbType="Float")]
		public System.Nullable<double> ds_th_nnlt
		{
			get
			{
				return this._ds_th_nnlt;
			}
			set
			{
				if ((this._ds_th_nnlt != value))
				{
					this._ds_th_nnlt = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ds_lthdt", DbType="Float")]
		public System.Nullable<double> ds_lthdt
		{
			get
			{
				return this._ds_lthdt;
			}
			set
			{
				if ((this._ds_lthdt != value))
				{
					this._ds_lthdt = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ds_th_lthdt", DbType="Float")]
		public System.Nullable<double> ds_th_lthdt
		{
			get
			{
				return this._ds_th_lthdt;
			}
			set
			{
				if ((this._ds_th_lthdt != value))
				{
					this._ds_th_lthdt = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ds_ctdl_gt", DbType="Float")]
		public System.Nullable<double> ds_ctdl_gt
		{
			get
			{
				return this._ds_ctdl_gt;
			}
			set
			{
				if ((this._ds_ctdl_gt != value))
				{
					this._ds_ctdl_gt = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ds_th_ctdlgt", DbType="Float")]
		public System.Nullable<double> ds_th_ctdlgt
		{
			get
			{
				return this._ds_th_ctdlgt;
			}
			set
			{
				if ((this._ds_th_ctdlgt != value))
				{
					this._ds_th_ctdlgt = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ds_csdl", DbType="Float")]
		public System.Nullable<double> ds_csdl
		{
			get
			{
				return this._ds_csdl;
			}
			set
			{
				if ((this._ds_csdl != value))
				{
					this._ds_csdl = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ds_th_csdl", DbType="Float")]
		public System.Nullable<double> ds_th_csdl
		{
			get
			{
				return this._ds_th_csdl;
			}
			set
			{
				if ((this._ds_th_csdl != value))
				{
					this._ds_th_csdl = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ds_toancc", DbType="Float")]
		public System.Nullable<double> ds_toancc
		{
			get
			{
				return this._ds_toancc;
			}
			set
			{
				if ((this._ds_toancc != value))
				{
					this._ds_toancc = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_diemtlhe4", DbType="Float")]
		public System.Nullable<double> diemtlhe4
		{
			get
			{
				return this._diemtlhe4;
			}
			set
			{
				if ((this._diemtlhe4 != value))
				{
					this._diemtlhe4 = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ds_diemtlhe10", DbType="Float")]
		public System.Nullable<double> ds_diemtlhe10
		{
			get
			{
				return this._ds_diemtlhe10;
			}
			set
			{
				if ((this._ds_diemtlhe10 != value))
				{
					this._ds_diemtlhe10 = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_dc_nnlt", DbType="NVarChar(255)")]
		public string dc_nnlt
		{
			get
			{
				return this._dc_nnlt;
			}
			set
			{
				if ((this._dc_nnlt != value))
				{
					this._dc_nnlt = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_dc_th_nnlt", DbType="NVarChar(255)")]
		public string dc_th_nnlt
		{
			get
			{
				return this._dc_th_nnlt;
			}
			set
			{
				if ((this._dc_th_nnlt != value))
				{
					this._dc_th_nnlt = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_dc_lthdt", DbType="NVarChar(255)")]
		public string dc_lthdt
		{
			get
			{
				return this._dc_lthdt;
			}
			set
			{
				if ((this._dc_lthdt != value))
				{
					this._dc_lthdt = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_dc_th_lthdt", DbType="NVarChar(255)")]
		public string dc_th_lthdt
		{
			get
			{
				return this._dc_th_lthdt;
			}
			set
			{
				if ((this._dc_th_lthdt != value))
				{
					this._dc_th_lthdt = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_dc_ctdl_gt", DbType="NVarChar(255)")]
		public string dc_ctdl_gt
		{
			get
			{
				return this._dc_ctdl_gt;
			}
			set
			{
				if ((this._dc_ctdl_gt != value))
				{
					this._dc_ctdl_gt = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_dc_th_ctdlgt", DbType="NVarChar(255)")]
		public string dc_th_ctdlgt
		{
			get
			{
				return this._dc_th_ctdlgt;
			}
			set
			{
				if ((this._dc_th_ctdlgt != value))
				{
					this._dc_th_ctdlgt = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_dc_csdl", DbType="NVarChar(255)")]
		public string dc_csdl
		{
			get
			{
				return this._dc_csdl;
			}
			set
			{
				if ((this._dc_csdl != value))
				{
					this._dc_csdl = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_dc_th_csdl", DbType="NVarChar(255)")]
		public string dc_th_csdl
		{
			get
			{
				return this._dc_th_csdl;
			}
			set
			{
				if ((this._dc_th_csdl != value))
				{
					this._dc_th_csdl = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_dc_toancc", DbType="NVarChar(255)")]
		public string dc_toancc
		{
			get
			{
				return this._dc_toancc;
			}
			set
			{
				if ((this._dc_toancc != value))
				{
					this._dc_toancc = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_dc_diemtlhe10", DbType="NVarChar(255)")]
		public string dc_diemtlhe10
		{
			get
			{
				return this._dc_diemtlhe10;
			}
			set
			{
				if ((this._dc_diemtlhe10 != value))
				{
					this._dc_diemtlhe10 = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_chuyennganh", DbType="NVarChar(255)")]
		public string chuyennganh
		{
			get
			{
				return this._chuyennganh;
			}
			set
			{
				if ((this._chuyennganh != value))
				{
					this._chuyennganh = value;
				}
			}
		}
	}
}
#pragma warning restore 1591
