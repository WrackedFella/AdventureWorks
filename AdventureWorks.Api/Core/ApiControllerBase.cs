using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using AdventureWorks.Domain;
using AdventureWorks.Domain.Core;
using AdventureWorks.Domain.Extensions;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;

namespace AdventureWorks.Api.Core
{
    [Route("api/[controller]")]
    [Authorize(AuthenticationSchemes = CookieAuthenticationDefaults.AuthenticationScheme)]
    public abstract class ApiControllerBase : ControllerBase
    {
        protected readonly AdventureWorksContext Context;
        protected string Username { get; }

        protected ApiControllerBase(AdventureWorksContext context, IHttpContextAccessor contextAccessor)
        {
            this.Context = context;
            this.Username = contextAccessor?.HttpContext?.User?.Identity?.Name ?? "Test";
        }
    }

    [Route("api/[controller]")]
    [Authorize(AuthenticationSchemes = CookieAuthenticationDefaults.AuthenticationScheme)]
    public abstract class ApiControllerBase<TEntity> : Controller
        where TEntity : EntityBase
    {
        protected readonly AdventureWorksContext Context;
        protected string Username { get; }
        public IPAddress PrinterIpAddress { get; set; }
        public bool IsUnitTest { get; set; } = false;

        protected ApiControllerBase(AdventureWorksContext context, IHttpContextAccessor contextAccessor)
        {
            this.Context = context;
            this.Username = contextAccessor?.HttpContext?.User?.Identity?.Name ?? "Test";
        }

		[HttpGet]
        [ProducesResponseType(200)]
        [ProducesResponseType(404)]
        public abstract ActionResult<IQueryable<TEntity>> Get();

        [HttpGet("{key}")]
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        public abstract Task<ActionResult<TEntity>> Get(Guid key);

        [HttpPost]
        [ProducesResponseType(201)]
        [ProducesResponseType(400)]
        public async Task<ActionResult> Post([FromBody] TEntity model)
		{
			await this.Context.Set<TEntity>().AddAsync(model);
			await this.Context.SaveChangesAsync(this.Username);

            return CreatedAtRoute(new { id = model.GetId() }, model);
        }

        [HttpPut("{key}")]
        [ProducesResponseType(202)]
        [ProducesResponseType(404)]
        public async Task<ActionResult> Put(Guid key, [FromBody] TEntity model)
		{
			var updateTarget = await this.Context.Set<TEntity>().FindAsync(key);
			if (updateTarget == null)
			{
			    return NotFound();
            }

			this.Context.Entry(updateTarget).UpdateRecord(model);
			await this.Context.SaveChangesAsync(this.Username);

			return AcceptedAtRoute(new { key }, model);
        }

        [HttpPatch("{key}")]
        public async Task<ActionResult> Patch(Guid key, [FromBody]JsonPatchDocument<TEntity> patch)
        {
            var target = await this.Context.Set<TEntity>().FindAsync(key);
            if (target == null)
            {
                return NotFound();
            }

            patch.ApplyTo(target);
	        await this.Context.SaveChangesAsync(this.Username);

			return AcceptedAtRoute(new { key }, target);
        }

        [HttpDelete("{key}")]
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        public async Task<ActionResult> Delete(Guid key)
		{
			var target = await this.Context.Set<TEntity>().FindAsync(key);
			target.Deactivate();
			await this.Context.SaveChangesAsync(this.Username);

			return Ok();
        }
    }
}
