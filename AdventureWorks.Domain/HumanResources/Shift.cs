using System;
using System.Collections.Generic;
using AdventureWorks.Core;

namespace AdventureWorks.Domain.HumanResources
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
