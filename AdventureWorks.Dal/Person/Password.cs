using AdventureWorks.Core;
using System;

namespace AdventureWorks.Dal.Person
{
	public class Password : EntityBase
	{
		public int BusinessEntityId { get; set; }
		public string PasswordHash { get; set; }
		public string PasswordSalt { get; set; }
		public Guid Rowguid { get; set; }

		public virtual Person BusinessEntity { get; set; }
	}
}
