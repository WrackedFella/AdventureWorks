using AdventureWorks.Core;
using System;

namespace AdventureWorks.Dal.HumanResources
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
