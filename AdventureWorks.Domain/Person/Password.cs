using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using AdventureWorks.Core;

namespace AdventureWorks.Domain.Person
{
	public class Password : EntityBase
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int BusinessEntityId
		{
			get => this.Id;
			set => this.Id = value;
		}

		public string PasswordHash { get; set; }
		public string PasswordSalt { get; set; }
		public Guid Rowguid { get; set; }

		public virtual Person BusinessEntity { get; set; }
	}
}
