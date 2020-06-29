using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace AdventureWorks.Api.Extensions
{
    public static class CustomExtensions
    {
        public static string GetUserName(this IHttpContextAccessor contextAccessor)
        {
            return contextAccessor?.HttpContext?.User?.Identity?.Name ?? "Test";
        }
    }
}
