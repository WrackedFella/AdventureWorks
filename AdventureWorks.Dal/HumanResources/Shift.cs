﻿using System;
using System.Collections.Generic;

namespace AdventureWorks.Dal.HumanResources
{
	public partial class Shift
	{
		public byte ShiftId { get; set; }
		public string Name { get; set; }
		public TimeSpan StartTime { get; set; }
		public TimeSpan EndTime { get; set; }
		public DateTime ModifiedDate { get; set; }

		public virtual ICollection<EmployeeDepartmentHistory> EmployeeDepartmentHistory { get; set; } = new HashSet<EmployeeDepartmentHistory>();
	}
}
