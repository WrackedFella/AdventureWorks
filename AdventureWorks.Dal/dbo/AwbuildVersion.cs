using AdventureWorks.Core;
using System;

namespace AdventureWorks.Dal.dbo
{
	public class AwbuildVersion : EntityBase
	{
		public byte SystemInformationId { get; set; }
		public string DatabaseVersion { get; set; }
		public DateTime VersionDate { get; set; }
	}
}
