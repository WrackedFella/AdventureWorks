using AdventureWorks.Domain.Purchasing;
using AdventureWorks.Repository.Purchasing.Models;
using AutoMapper;
using AutoMapper.Configuration;
using Microsoft.EntityFrameworkCore;

namespace AdventureWorks.Repository.Purchasing.Repositories
{
	public class PurchaseOrderHeaderRepository : RepositoryBase<PurchaseOrderHeader, PurchaseOrderHeaderModel>
	{
		public static object Foo = new object();
		public PurchaseOrderHeaderRepository(DbContext context) : base(context)
		{
			if (this.MapperInstance == null)
			{
				var configExpression = new MapperConfigurationExpression();
				configExpression.CreateMap<PurchaseOrderHeader, PurchaseOrderHeaderModel>()
					.ForMember(dest => dest.ShipMethodDisplayName, opt => opt.MapFrom(src => src.ShipMethod.Name))
					.ForMember(dest => dest.VendorDisplayName, opt => opt.MapFrom(src => src.Vendor.Name));
				configExpression.CreateMap<PurchaseOrderHeaderModel, PurchaseOrderHeader>();
				configExpression.CreateMap<PurchaseOrderDetail, PurchaseOrderDetailModel>().ReverseMap();

				this.MapperConfig = new MapperConfiguration(configExpression);
				this.MapperInstance = this.MapperConfig.CreateMapper();
			}
		}
		//~PurchaseOrderHeaderRepository()
		//{
		//	Mapper.Reset();
		//}
	}
}
