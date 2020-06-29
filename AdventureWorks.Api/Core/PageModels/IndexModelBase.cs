using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AdventureWorks.Domain;
using AdventureWorks.Domain.Core;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace AdventureWorks.Api.Core.PageModels
{
    public abstract class IndexModelBase<TEntity> : PageModel
        where TEntity : EntityBase
    {
	    protected readonly AdventureWorksContext Context;

        protected IndexModelBase(AdventureWorksContext context)
        {
            this.Context = context;
		}

        public virtual async Task<JsonResult> OnGetGridDataAsync()
        {
            // ToDo: Support filters and paging
            List<TEntity> resultSet;
            if (bool.TryParse(this.Request.Query["isActiveFilter"], out var isActive))
            {
                resultSet = await this.Context.Set<TEntity>()
                    .Where(x => x.IsActive == isActive)
                    .AsNoTracking()
                    .ToListAsync();
            }
            else
            {
                resultSet = await this.Context.Set<TEntity>()
                    .Where(x => x.IsActive)
                    .AsNoTracking()
                    .ToListAsync();
            }
            return new JsonResult(resultSet);
        }
    }
}
