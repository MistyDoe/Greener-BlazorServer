using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Greener.Pages
{
    public class LogoutModel : PageModel
    {
        public string ReturnUrl { get; private set; }
        public async Task<IActionResult> OnGetAsync (string returnUrl = null)
        {
            returnUrl = returnUrl ?? Url.Content("~/");
            try
            {
                await HttpContext
                    .SignOutAsync(
                    CookieAuthenticationDefaults.AuthenticationScheme);
            }
            catch ( Exception ex )
            {
                string error = ex.Message;
            }
            return LocalRedirect("/");
        }
    }
}