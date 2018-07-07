using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using AdventureWorks.Core;
using AdventureWorks.Domain.Purchasing;
using AdventureWorks.Domain.Sales;

namespace AdventureWorks.Domain.Person
{
	public class BusinessEntity : EntityBase
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int BusinessEntityId
		{
			get => this.Id;
			set => this.Id = value;
		}

		public Guid Rowguid { get; set; }
	}
}
