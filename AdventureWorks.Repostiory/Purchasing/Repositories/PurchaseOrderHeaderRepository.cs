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
				x.CreateMap<PurchaseOrderHeader, PurchaseOrderHeaderModel>()
					.ForMember(dest => dest.ShipMethodDisplayName, opt => opt.MapFrom(src => src.ShipMethod.Name))
					.ForMember(dest => dest.VendorDisplayName, opt => opt.MapFrom(src => src.Vendor.Name));
				x.CreateMap<PurchaseOrderHeaderModel, PurchaseOrderHeader>();
				x.CreateMap<PurchaseOrderDetail, PurchaseOrderDetailModel>().ReverseMap();
			});
		}
	}
}
