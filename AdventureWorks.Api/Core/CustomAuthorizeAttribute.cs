using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AdventureWorks.Domain.Core;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;

namespace AdventureWorks.Api.Core
{
    public class CustomAuthorizeAttribute : AuthorizeAttribute
    {
        public CustomAuthorizeAttribute(params string[] roles) : base()
        {
            this.AuthenticationSchemes = CookieAuthenticationDefaults.AuthenticationScheme;
            this.Roles = string.Join(",", roles, MyRoles.Admin);
        }
    }
}
