using System;
using System.Threading.Tasks;
using AdventureWorks.Domain;
using AdventureWorks.Domain.Core;
using AdventureWorks.Domain.Extensions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AdventureWorks.Api.Core.PageModels
{
    public abstract class EditModelBase<TEntity> : PageModelBase
        where TEntity : EntityBase, new()
    {
        protected EditModelBase(AdventureWorksContext context, IHttpContextAccessor contextAccessor) : base(context, contextAccessor)
        {
        }

        [BindProperty] public TEntity Record { get; set; }

        public Guid RecordId { get; set; }

        public virtual async Task<IActionResult> OnGetAsync(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            this.RecordId = (Guid) id;
            this.Record = await this.Context.Set<TEntity>().FindAsync(id);

            if (this.Record == null)
            {
                return NotFound();
            }
            if (!this.Record.IsActive)
            {
                return RedirectToPage("./Details", new { id });
            }

            return await LoadPageAsync();
        }

        public virtual async Task<IActionResult> OnPostAsync(Guid id)
        {
            if (!this.ModelState.IsValid)
            {
                // ToDo: Invoke a delegate here to populate view data
                this.RecordId = id;
                return await LoadPageAsync();
            }

            // ToDo: DbConcurrencyError check?
            var updateTarget = await this.Context.Set<TEntity>().FindAsync(id);
            if (updateTarget == null)
            {
                throw new NullReferenceException("Could not find record.");
            }

            this.Context.Entry(updateTarget).UpdateRecord(this.Record);

            await this.Context.SaveChangesAsync(this.Username);

            return RedirectToPage("./Details", new { id });
        }

        public virtual async Task<IActionResult> LoadPageAsync()
        {
            return Page();
        }

    }
}
