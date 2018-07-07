using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AdventureWorks.Core
{
	public abstract class EntityBase
	{
		protected int Id { get; set; }

		public int GetId()
		{
			return this.Id;
		}

		public string ModifiedBy { get; set; }
		public DateTimeOffset ModifiedDate { get; set; }
		public string CreatedBy { get; set; }
		public DateTimeOffset CreatedDate { get; set; }
	}
}
