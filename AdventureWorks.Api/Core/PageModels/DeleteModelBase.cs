using System;
using System.Threading.Tasks;
using AdventureWorks.Domain;
using AdventureWorks.Domain.Core;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AdventureWorks.Api.Core.PageModels
{
    public abstract class DeleteModelBase<TEntity> : PageModelBase
        where TEntity : EntityBase
    {
        protected DeleteModelBase(AdventureWorksContext context, IHttpContextAccessor contextAccessor) : base(context, contextAccessor)
        {
        }

        [BindProperty]
        public TEntity Record { get; set; }
        [BindProperty]
        public Guid RecordId { get; set; }

        public virtual async Task<IActionResult> OnGetAsync(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            this.RecordId = (Guid)id;
            this.Record = await this.Context.Set<TEntity>().FindAsync((Guid)id);

            if (this.Record == null)
            {
                return NotFound();
            }

            return Page();
        }

        public async Task<IActionResult> OnPostAsync(Guid id)
        {
            this.Record = await this.Context.Set<TEntity>().FindAsync(id);
            this.Record.Deactivate();
			await this.Context.SaveChangesAsync(this.Username);
			return RedirectToPage("./Index");
        }
    }
}
