using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using AdventureWorks.Core;
using AdventureWorks.Domain.Person;

namespace AdventureWorks.Domain.Sales
{
	public class Store : EntityBase
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.None)]
		public int BusinessEntityId
		{
			get => this.Id;
			set => this.Id = value;
		}
		public string Name { get; set; }
		public int? SalesPersonId { get; set; }
		public string Demographics { get; set; }
		public Guid Rowguid { get; set; }

		public virtual BusinessEntity BusinessEntity { get; set; }
		public virtual SalesPerson SalesPerson { get; set; }
		public virtual ICollection<Customer> Customer { get; set; } = new HashSet<Customer>();
	}
}
