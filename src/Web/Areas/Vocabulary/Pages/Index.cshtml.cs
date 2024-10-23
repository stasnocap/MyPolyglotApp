using Infrastructure.Persistence.Seed.Identity;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Web.Areas.Vocabulary.Pages;

[Authorize(Roles = IdentityRoleSeed.AdminRole)]
public class Index : PageModel
{
    public void OnGet()
    {
        
    }
}