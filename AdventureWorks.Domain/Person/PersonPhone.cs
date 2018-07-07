using AdventureWorks.Core;

namespace AdventureWorks.Domain.Person
{
	public class PersonPhone : EntityBase
	{
		public int BusinessEntityId { get; set; }
		public string PhoneNumber { get; set; }
		public int PhoneNumberTypeId { get; set; }

		public virtual Person BusinessEntity { get; set; }
		public virtual PhoneNumberType PhoneNumberType { get; set; }
	}
}
