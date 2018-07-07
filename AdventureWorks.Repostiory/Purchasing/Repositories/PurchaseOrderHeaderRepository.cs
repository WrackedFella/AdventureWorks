using System;
using System.Collections.Generic;
using AdventureWorks.Core;
using AdventureWorks.Dal.Purchasing;
using AdventureWorks.Repository.Purchasing.Models;
using AutoMapper;
using Microsoft.EntityFrameworkCore;

namespace AdventureWorks.Repository.Purchasing.Repositories
{
	public class PurchaseOrderHeaderRepository : RepositoryBase<PurchaseOrderHeader, PurchaseOrderHeaderModel>
	{
		public PurchaseOrderHeaderRepository(DbContext context, params Profile[] profiles) : base(context, profiles)
		{
		}
	}
}
