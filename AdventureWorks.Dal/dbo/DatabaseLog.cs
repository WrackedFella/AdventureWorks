using AdventureWorks.Core;
using System;

namespace AdventureWorks.Dal.dbo
{
	public class DatabaseLog : EntityBase
	{
		public int DatabaseLogId { get; set; }
		public DateTime PostTime { get; set; }
		public string Tsql { get; set; }
		public string XmlEvent { get; set; }
	}
}
