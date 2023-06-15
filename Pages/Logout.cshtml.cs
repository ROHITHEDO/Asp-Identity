using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Threading.Tasks;

namespace Asp_Identity.Pages
{
    public class LogoutModel : PageModel
    {
        private readonly SignInManager<IdentityUser> _signInManger;

        public LogoutModel(SignInManager<IdentityUser> signInManager)
        {
            _signInManger = signInManager;
        }
        public void OnGet()
        {

        }

        public async Task<IActionResult> OnPostLogoutAsync()
        {
            await _signInManger.SignOutAsync();
            return RedirectToPage("Login");
        }

        public IActionResult OnPostDontLogoutAsync()
        {
            return RedirectToPage("Index");
        }
    }
}
