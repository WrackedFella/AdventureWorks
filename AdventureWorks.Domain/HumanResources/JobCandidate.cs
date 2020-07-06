using System.ComponentModel.DataAnnotations;
using AdventureWorks.Domain.Core;

namespace AdventureWorks.Domain.HumanResources
{
    public class JobCandidate : EntityBase
    {
	    [Key]
        public int JobCandidateId { get; set; }
        public int? BusinessEntityId { get; set; }
        public string Resume { get; set; }

        public virtual Employee BusinessEntity { get; set; }
    }
}
