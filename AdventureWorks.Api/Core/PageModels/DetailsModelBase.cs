using System;
using System.Threading.Tasks;
using AdventureWorks.Domain;
using AdventureWorks.Domain.Core;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AdventureWorks.Api.Core.PageModels
{
    public abstract class DetailsModelBase<TEntity> : PageModelBase
        where TEntity : EntityBase
    {

        protected DetailsModelBase(AdventureWorksContext context, IHttpContextAccessor contextAccessor) : base(context, contextAccessor)
        {
        }

        [BindProperty]
        public TEntity Record { get; set; }
        [BindProperty]
        public Guid RecordId { get; set; }

        public virtual async Task<IActionResult> OnGetAsync(Guid id)
        {
            this.RecordId = id;
            this.Record = await this.Context.Set<TEntity>().FindAsync(id);

			if (this.Record == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
