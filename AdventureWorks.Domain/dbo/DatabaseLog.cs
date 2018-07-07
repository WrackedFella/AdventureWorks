using System;
using AdventureWorks.Core;

namespace AdventureWorks.Domain.dbo
{
	public class DatabaseLog : EntityBase
	{
		public int DatabaseLogId { get; set; }
		public DateTime PostTime { get; set; }
		public string Tsql { get; set; }
		public string XmlEvent { get; set; }
	}
}
