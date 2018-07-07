using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using AdventureWorks.Core;

namespace AdventureWorks.Domain.HumanResources
{
	public class EmployeeDepartmentHistory : EntityBase
	{
		[Key]
		[Column(Order = 0)]
		public int BusinessEntityId { get; set; }

		[Key]
		[Column(Order = 1)]
		public short DepartmentId { get; set; }

		[Key]
		[Column(Order = 2)]
		public byte ShiftId { get; set; }

		[Key]
		[Column(Order = 3)]
		public DateTime StartDate { get; set; }

		public DateTime? EndDate { get; set; }

		public virtual Employee BusinessEntity { get; set; }
		public virtual Department Department { get; set; }
		public virtual Shift Shift { get; set; }
	}
}
