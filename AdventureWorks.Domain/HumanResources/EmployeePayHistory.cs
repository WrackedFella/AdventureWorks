using System;
using AdventureWorks.Core;

namespace AdventureWorks.Domain.HumanResources
{
	public class EmployeePayHistory : EntityBase
	{
		public int BusinessEntityId { get; set; }
		public DateTime RateChangeDate { get; set; }
		public decimal Rate { get; set; }
		public byte PayFrequency { get; set; }

		public virtual Employee BusinessEntity { get; set; }
	}
}
