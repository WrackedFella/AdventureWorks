using System;
using System.ComponentModel.DataAnnotations;
using AdventureWorks.Domain.Core;

namespace AdventureWorks.Domain.Person
{
    public class Password : EntityBase
    {
	    [Key]
        public int BusinessEntityId { get; set; }
        public string PasswordHash { get; set; }
        public string PasswordSalt { get; set; }
        public Guid Rowguid { get; set; }

        public virtual Person BusinessEntity { get; set; }
    }
}
