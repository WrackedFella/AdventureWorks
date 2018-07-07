using AdventureWorks.Core;

namespace AdventureWorks.Domain.Sales
{
	public class PersonCreditCard : EntityBase
	{
		public int BusinessEntityId { get; set; }
		public int CreditCardId { get; set; }

		public virtual Person.Person BusinessEntity { get; set; }
		public virtual CreditCard CreditCard { get; set; }
	}
}
