﻿using AdventureWorks.Dal.Sales;
using System;
using System.Collections.Generic;

namespace AdventureWorks.Dal.Person
{
	public partial class StateProvince
	{
		public int StateProvinceId { get; set; }
		public string StateProvinceCode { get; set; }
		public string CountryRegionCode { get; set; }
		public bool? IsOnlyStateProvinceFlag { get; set; }
		public string Name { get; set; }
		public int TerritoryId { get; set; }
		public Guid Rowguid { get; set; }
		public DateTime ModifiedDate { get; set; }

		public virtual CountryRegion CountryRegionCodeNavigation { get; set; }
		public virtual SalesTerritory Territory { get; set; }
		public virtual ICollection<Address> Address { get; set; } = new HashSet<Address>();
		public virtual ICollection<SalesTaxRate> SalesTaxRate { get; set; } = new HashSet<SalesTaxRate>();
	}
}
