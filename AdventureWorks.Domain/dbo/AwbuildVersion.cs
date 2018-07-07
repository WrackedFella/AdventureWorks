using System;
using AdventureWorks.Core;

namespace AdventureWorks.Domain.dbo
{
	public class AwbuildVersion : EntityBase
	{
		public byte SystemInformationId { get; set; }
		public string DatabaseVersion { get; set; }
		public DateTime VersionDate { get; set; }
	}
}
