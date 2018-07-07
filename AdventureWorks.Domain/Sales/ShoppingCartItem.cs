using System;
using AdventureWorks.Core;
using AdventureWorks.Domain.Production;

namespace AdventureWorks.Domain.Sales
{
	public class ShoppingCartItem : EntityBase
	{
		public int ShoppingCartItemId { get; set; }
		public string ShoppingCartId { get; set; }
		public int Quantity { get; set; }
		public int ProductId { get; set; }
		public DateTime DateCreated { get; set; }

		public virtual Product Product { get; set; }
	}
}
