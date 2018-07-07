using AdventureWorks.Core;
using System.Collections.Generic;

namespace AdventureWorks.Dal.HumanResources
{
	public class Department : EntityBase
	{
		public short DepartmentId { get; set; }
		public string Name { get; set; }
		public string GroupName { get; set; }

		public virtual ICollection<EmployeeDepartmentHistory> EmployeeDepartmentHistory { get; set; } = new HashSet<EmployeeDepartmentHistory>();
	}
}
