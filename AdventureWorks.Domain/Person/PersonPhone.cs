using System.ComponentModel.DataAnnotations;
using AdventureWorks.Domain.Core;

namespace AdventureWorks.Domain.Person
{
    public class PersonPhone : EntityBase
    {
	    [Key]
        public int BusinessEntityId { get; set; }
        [Key]
        public string PhoneNumber { get; set; }
        [Key]
        public int PhoneNumberTypeId { get; set; }

        public virtual Person BusinessEntity { get; set; }
        public virtual PhoneNumberType PhoneNumberType { get; set; }
    }
}
