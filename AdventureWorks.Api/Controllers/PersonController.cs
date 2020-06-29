using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AdventureWorks.Api.Core;
using AdventureWorks.Domain;
using AdventureWorks.Domain.Person;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AdventureWorks.Api.Controllers
{
    public class PersonController : ApiControllerBase<Person>
    {

        public PersonController(AdventureWorksContext context, IHttpContextAccessor contextAccessor) : base(context, contextAccessor)
        {
            
        }

        public override ActionResult<IQueryable<Person>> Get()
        {
            return this.Context.Persons;
        }

        public override async Task<ActionResult<Person>> Get(Guid key)
        {
            return await this.Context.Persons.FindAsync(key);
        }
    }
}
