using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using AdventureWorks.Domain.Core;
using AdventureWorks.Domain.Person;

namespace AdventureWorks.Domain.Sales
{
    public class Store  : EntityBase
    {
	    [Key]
        public int BusinessEntityId { get; set; }
        public string Name { get; set; }
        public int? SalesPersonId { get; set; }
        public string Demographics { get; set; }
        public Guid Rowguid { get; set; }
        
        public virtual BusinessEntity BusinessEntity { get; set; }
        public virtual SalesPerson SalesPerson { get; set; }
        public virtual ICollection<Customer> Customer { get; set; } = new HashSet<Customer>();
    }
}
