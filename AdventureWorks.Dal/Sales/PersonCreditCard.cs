﻿using System;

namespace AdventureWorks.Dal.Sales
{
	public partial class PersonCreditCard
	{
		public int BusinessEntityId { get; set; }
		public int CreditCardId { get; set; }
		public DateTime ModifiedDate { get; set; }

		public virtual Person.Person BusinessEntity { get; set; }
		public virtual CreditCard CreditCard { get; set; }
	}
}
