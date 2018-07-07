using System;

namespace AdventureWorks.Core
{
	public abstract class ModelBase
	{
		protected int Id { get; set; }

		public int GetId()
		{
			return this.Id;
		}
	}
}
