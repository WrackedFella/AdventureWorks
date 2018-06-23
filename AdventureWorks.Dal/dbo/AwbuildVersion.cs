﻿using System;

namespace AdventureWorks.Dal.dbo
{
	public partial class AwbuildVersion
	{
		public byte SystemInformationId { get; set; }
		public string DatabaseVersion { get; set; }
		public DateTime VersionDate { get; set; }
		public DateTime ModifiedDate { get; set; }
	}
}
