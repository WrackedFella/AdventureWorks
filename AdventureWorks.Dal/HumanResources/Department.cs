using System;
using System.Collections.Generic;

namespace AdventureWorks.Dal.HumanResources
{
	public partial class Department
	{
		public short DepartmentId { get; set; }
		public string Name { get; set; }
		public string GroupName { get; set; }
		public DateTime ModifiedDate { get; set; }

		public virtual ICollection<EmployeeDepartmentHistory> EmployeeDepartmentHistory { get; set; } = new HashSet<EmployeeDepartmentHistory>();
	}
}
