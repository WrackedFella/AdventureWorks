using AdventureWorks.Core;
using System;
using System.Collections.Generic;

namespace AdventureWorks.Dal.HumanResources
{
	public class Shift : EntityBase
	{
		public byte ShiftId { get; set; }
		public string Name { get; set; }
		public TimeSpan StartTime { get; set; }
		public TimeSpan EndTime { get; set; }

		public virtual ICollection<EmployeeDepartmentHistory> EmployeeDepartmentHistory { get; set; } = new HashSet<EmployeeDepartmentHistory>();
	}
}
