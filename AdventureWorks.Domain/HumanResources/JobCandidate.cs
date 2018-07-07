using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using AdventureWorks.Core;

namespace AdventureWorks.Domain.HumanResources
{
	public class JobCandidate : EntityBase
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int JobCandidateId
		{
			get => this.Id;
			set => this.Id = value;
		}

		public int? BusinessEntityId { get; set; }
		public string Resume { get; set; }

		public virtual Employee BusinessEntity { get; set; }
	}
}
