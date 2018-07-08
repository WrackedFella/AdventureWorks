using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AdventureWorks.Domain;
using AdventureWorks.Repository.Purchasing.Models;
using AdventureWorks.Repository.Purchasing.Repositories;

namespace AdventureWorks.Services.Purchasing
{
	public class PurchasingService
	{
		private PurchaseOrderHeaderRepository _repo;

		public PurchasingService(AdventureWorksContext context)
		{
			this._repo = new PurchaseOrderHeaderRepository(context);
		}

		public async Task<IEnumerable<PurchaseOrderHeaderModel>> CreatePurchaseOrderHeaders(params PurchaseOrderHeaderModel[] purchaseOrders)
		{
			var results = purchaseOrders.Select(async po => await this._repo.Insert(po));

			throw new System.NotImplementedException();
		}
	}
}
