using AdventureWorks.Core;
using System;

namespace AdventureWorks.Dal.HumanResources
{
	public class EmployeeDepartmentHistory : EntityBase
	{
		public int BusinessEntityId { get; set; }
		public short DepartmentId { get; set; }
		public byte ShiftId { get; set; }
		public DateTime StartDate { get; set; }
		public DateTime? EndDate { get; set; }

		public virtual Employee BusinessEntity { get; set; }
		public virtual Department Department { get; set; }
		public virtual Shift Shift { get; set; }
	}
}
