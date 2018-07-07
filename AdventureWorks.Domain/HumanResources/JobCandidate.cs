﻿using AdventureWorks.Core;

namespace AdventureWorks.Domain.HumanResources
{
	public class JobCandidate : EntityBase
	{
		public int JobCandidateId { get; set; }
		public int? BusinessEntityId { get; set; }
		public string Resume { get; set; }

		public virtual Employee BusinessEntity { get; set; }
	}
}