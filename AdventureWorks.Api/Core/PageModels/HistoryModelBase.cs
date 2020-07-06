using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AdventureWorks.Domain;
using AdventureWorks.Domain.Core;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

namespace AdventureWorks.Api.Core.PageModels
{
    public abstract class HistoryModelBase<TEntity> : PageModelBase
        where TEntity : EntityBase
    {
	    public TEntity Record { get; set; }
        public Guid RecordId { get; set; }
        private string TableName { get; }
        private readonly List<string> _auditFields = new List<string> { "LastModifiedBy", "LastModifiedDate", "CreatedBy", "CreatedDate" };

        protected HistoryModelBase(AdventureWorksContext context, IHttpContextAccessor contextAccessor) : base(context, contextAccessor)
        {
            switch (typeof(TEntity).Name)
            {
                case "Child":
                    this.TableName = "Children";
                    break;
                case "Mother":
                    this.TableName = "Mothers";
                    break;
                default:
                    this.TableName = "Unknown";
                    break;
            }
        }

        public async Task<IActionResult> OnGetAsync(Guid id)
        {
            this.Record = await this.Context.Set<TEntity>().FindAsync(id);
            if (this.Record == null)
            {
                return NotFound();
            }
            this.RecordId = id;
            return Page();
        }

        //public virtual async Task<JsonResult> OnGetGridDataAsync(Guid id, Guid logId)
        //{
        //    foreach (var ah in await this.Context.AuditHistory.Where(x => x.TableName == this.TableName && x.RowId.ToUpper() == id.ToString().ToUpper()).ToListAsync())
        //    {
        //        // Do the needful.
        //    }
            
        //    return new JsonResult(new { });
        //}

    }
}
