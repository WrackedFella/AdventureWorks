using AdventureWorks.Core;
using System;

namespace AdventureWorks.Dal.dbo
{
	public class ErrorLog : EntityBase
	{
		public int ErrorLogId { get; set; }
		public DateTime ErrorTime { get; set; }
		public int ErrorNumber { get; set; }
		public int? ErrorSeverity { get; set; }
		public int? ErrorState { get; set; }
		public string ErrorProcedure { get; set; }
		public int? ErrorLine { get; set; }
		public string ErrorMessage { get; set; }
	}
}
