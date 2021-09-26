using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using MyPolyglotWeb.Models.DomainModels;

namespace MyPolyglotWeb.Controllers.CustomAttributes
{
    public class IsAdminAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            if (!context.HttpContext.User.IsInRole(UserRole.Admin.ToString()))
            {
                context.Result = new ForbidResult();
            }
        }
    }
}
