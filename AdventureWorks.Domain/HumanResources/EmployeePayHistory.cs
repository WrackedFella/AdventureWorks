using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using AdventureWorks.Core;

namespace AdventureWorks.Domain.HumanResources
{
	public class EmployeePayHistory : EntityBase
	{
		[Key]
		[Column(Order = 0)]
		public int BusinessEntityId { get; set; }

		[Key]
		[Column(Order = 1)]
		public DateTime RateChangeDate { get; set; }

		public decimal Rate { get; set; }
		public byte PayFrequency { get; set; }

		public virtual Employee BusinessEntity { get; set; }
	}
}
