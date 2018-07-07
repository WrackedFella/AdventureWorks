using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using AdventureWorks.Core;

namespace AdventureWorks.Domain.Person
{
	public class AddressType : EntityBase
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int AddressTypeId
		{
			get => this.Id;
			set => this.Id = value;
		}

		public string Name { get; set; }
		public Guid Rowguid { get; set; }

		public virtual ICollection<BusinessEntityAddress> BusinessEntityAddress { get; set; } = new HashSet<BusinessEntityAddress>();
	}
}
