using System.Threading.Tasks;
using AdventureWorks.Domain;
using AdventureWorks.Domain.Core;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AdventureWorks.Api.Core.PageModels
{
    public abstract class CreateModelBase<TEntity> : PageModelBase
        where TEntity : EntityBase, new()
    {
        protected CreateModelBase(AdventureWorksContext context, IHttpContextAccessor contextAccessor) : base(context, contextAccessor)
        {
        }

        [BindProperty] public TEntity Record { get; set; } = new TEntity();

        public virtual async Task<IActionResult> OnGetAsync()
        {
            return await LoadPageAsync();
        }

        public virtual async Task<IActionResult> OnPostAsync()
        {
            if (!this.ModelState.IsValid)
            {
                return await LoadPageAsync();
            }

	        await this.Context.Set<TEntity>().AddAsync(this.Record);
	        await this.Context.SaveChangesAsync(this.Username);

            return RedirectToPage("./Details", new { id = this.Record.GetId() });
        }

        public virtual async Task<IActionResult> LoadPageAsync()
        {
            return Page();
        }
    }
}
