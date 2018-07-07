using System.Collections.Generic;
using AdventureWorks.Core;

namespace AdventureWorks.Domain.HumanResources
{
	public class Department : EntityBase
	{
		public short DepartmentId { get; set; }
		public string Name { get; set; }
		public string GroupName { get; set; }

		public virtual ICollection<EmployeeDepartmentHistory> EmployeeDepartmentHistory { get; set; } = new HashSet<EmployeeDepartmentHistory>();
	}
}
