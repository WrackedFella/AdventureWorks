using System;
using System.ComponentModel.DataAnnotations;

namespace AdventureWorks.Domain.HumanResources
{
    public class EmployeePayHistory : EntityBase
    {
	    [Key]
        public int BusinessEntityId { get; set; }
        [Key]
        public DateTime RateChangeDate { get; set; }
        public decimal Rate { get; set; }
        public byte PayFrequency { get; set; }

        public virtual Employee BusinessEntity { get; set; }
    }
}
