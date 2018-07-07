using AdventureWorks.Dal.Purchasing;
using AdventureWorks.Repository.Purchasing.Models;
using AutoMapper;

namespace AdventureWorks.Repository.Purchasing.Mappings
{
	public class PurchaseOrderHeaderProfile : Profile
	{
		public PurchaseOrderHeaderProfile()
		{
			CreateMap<PurchaseOrderHeader, PurchaseOrderHeaderModel>();
			CreateMap<PurchaseOrderHeader, PurchaseOrderHeaderModel>().ReverseMap();
		}
	}
}
