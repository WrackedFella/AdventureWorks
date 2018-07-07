using AdventureWorks.Dal.Purchasing;
using AdventureWorks.Repository.Purchasing.Models;
using AutoMapper;

namespace AdventureWorks.Repository.Purchasing.Mappings
{
	public class PurchaseOrderDetailProfile : Profile
	{
		public PurchaseOrderDetailProfile()
		{
			CreateMap<PurchaseOrderDetail, PurchaseOrderDetailModel>();
			CreateMap<PurchaseOrderDetail, PurchaseOrderDetailModel>().ReverseMap();
		}
	}
}
