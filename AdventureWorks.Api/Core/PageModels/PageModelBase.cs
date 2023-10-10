using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using AdventureWorks.Api.Extensions;
using AdventureWorks.Domain;
using AdventureWorks.Domain.Core;
using AdventureWorks.Domain.Extensions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json;

namespace AdventureWorks.Api.Core.PageModels
{
    public abstract class PageModelBase : PageModel
    {
        protected string Username { get; }
        protected string RoleName { get; }
        public bool IsSuperOrHigher { get; } = false;
        public bool IsMobile { get; } = false;
        public IPAddress PrinterIpAddress { get; set; }
        public bool IsUnitTest { get; set; } = false;
        protected AdventureWorksContext Context { get; set; }
        protected readonly CookieOptions MyCookieOptions = new CookieOptions
        {
            Expires = DateTimeOffset.Now.AddMinutes(2)
        };
        
        public string GetPageTitle() => this.GetPageName().AddSpaces();

        public string GetPageName() => this.GetType().Name.Replace("Model", "");


        protected PageModelBase(AdventureWorksContext context, IHttpContextAccessor contextAccessor)
        {
            this.Context = context;
            if (contextAccessor == null)
            {
                return; 
            }
            this.Username = contextAccessor.GetUserName();
            this.IsMobile = contextAccessor.HttpContext.Request.Headers["User-Agent"].ToString().Contains("Android");
            if (contextAccessor.HttpContext.User.IsInRole(MyRoles.Admin))
            {
                this.RoleName = MyRoles.Admin;
                this.IsSuperOrHigher = true;
                return;
            }
            if (contextAccessor.HttpContext.User.IsInRole(MyRoles.User))
            {
                this.RoleName = MyRoles.User;
                this.IsSuperOrHigher = true;
                return;
            }
        }

        protected T RetrieveCookie<T>(string key)
            where T : new()
        {
	        return this.Request?.Cookies[key] != null 
                ? JsonConvert.DeserializeObject<T>(this.Request?.Cookies[key]) 
                : new T();
        }

        protected void AppendCookie(string key, object value)
        {
            if (value != null)
            {
                this.Response?.Cookies.Append(
                    key, 
                    JsonConvert.SerializeObject(value), 
                    this.MyCookieOptions);
            }
        }

        protected void ResetCookie(string key)
        {
	        this.Response?.Cookies.Append(key, "", new CookieOptions
            {
	            Expires = DateTime.Now.AddDays(-1)
            });
        }
    }
}
