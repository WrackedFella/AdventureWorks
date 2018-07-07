using AdventureWorks.Domain.Purchasing;
using AdventureWorks.Repository.Purchasing.Models;
using AutoMapper;
using Microsoft.EntityFrameworkCore;

namespace AdventureWorks.Repository.Purchasing.Repositories
{
	public class PurchaseOrderHeaderRepository : RepositoryBase<PurchaseOrderHeader, PurchaseOrderHeaderModel>
	{
		public PurchaseOrderHeaderRepository(DbContext context) : base(context)
		{
			Mapper.Initialize(x =>
			{
				x.CreateMap<PurchaseOrderHeader, PurchaseOrderHeaderModel>();
				x.CreateMap<PurchaseOrderHeader, PurchaseOrderHeaderModel>().ReverseMap();
				x.CreateMap<PurchaseOrderDetail, PurchaseOrderDetailModel>();
				x.CreateMap<PurchaseOrderDetail, PurchaseOrderDetailModel>().ReverseMap();
			});
		}
	}
}
