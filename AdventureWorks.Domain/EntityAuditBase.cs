using System;

namespace AdventureWorks.Domain
{
	public abstract class EntityAuditBase : EntityBase
	{
		public string LastModifiedBy { get; set; }
		public string CreatedBy { get; set; }
		public DateTimeOffset LastModifiedDate { get; set; }
		public DateTimeOffset CreatedDate { get; set; }

		internal void SetAuditDetails(string username)
		{
			this.LastModifiedBy = username;
			this.LastModifiedDate = DateTimeOffset.Now;

			if (!string.IsNullOrEmpty(this.CreatedBy))
			{
				return;
			}
			this.CreatedBy = username;
			this.CreatedDate = DateTimeOffset.Now;
		}
	}
}
