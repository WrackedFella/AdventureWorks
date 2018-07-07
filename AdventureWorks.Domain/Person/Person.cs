using System;
using System.Collections.Generic;
using AdventureWorks.Core;
using AdventureWorks.Domain.HumanResources;
using AdventureWorks.Domain.Sales;

namespace AdventureWorks.Domain.Person
{
	public class Person : BusinessEntity
	{
		public string PersonType { get; set; }
		public bool NameStyle { get; set; }
		public string Title { get; set; }
		public string FirstName { get; set; }
		public string MiddleName { get; set; }
		public string LastName { get; set; }
		public string Suffix { get; set; }
		public int EmailPromotion { get; set; }
		public string AdditionalContactInfo { get; set; }
		public string Demographics { get; set; }
		public Guid Rowguid { get; set; }

		public virtual BusinessEntity BusinessEntity { get; set; }
		public virtual Employee Employee { get; set; }
		public virtual Password Password { get; set; }
		public virtual ICollection<BusinessEntityContact> BusinessEntityContact { get; set; } = new HashSet<BusinessEntityContact>();
		public virtual ICollection<Customer> Customer { get; set; } = new HashSet<Customer>();
		public virtual ICollection<EmailAddress> EmailAddress { get; set; } = new HashSet<EmailAddress>();
		public virtual ICollection<PersonCreditCard> PersonCreditCard { get; set; } = new HashSet<PersonCreditCard>();
		public virtual ICollection<PersonPhone> PersonPhone { get; set; } = new HashSet<PersonPhone>();
	}
}
