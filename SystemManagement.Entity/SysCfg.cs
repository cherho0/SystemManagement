﻿using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SystemManagement.Entity
{
	/// <summary>
	/// 系统参数
	/// </summary>
	[Table("SysCfg")]
	[Description("系统参数")]
	public class SysCfg : BaseEntity<long>
	{
		/// <summary>
		/// 备注
		/// </summary>
		[Description("备注")]
		[StringLength(65535)]
		[Column("CfgDesc")]
		public string CfgDesc { get; set; }

		/// <summary>
		/// 参数名
		/// </summary>
		[Description("参数名")]
		[StringLength(256)]
		[Column("CfgName")]
		public string CfgName { get; set; }

		/// <summary>
		/// 参数值
		/// </summary>
		[Description("参数值")]
		[StringLength(512)]
		[Column("CfgValue")]
		public string CfgValue { get; set; }
	}
}
