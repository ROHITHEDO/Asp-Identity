using Asp_Identity.ViewModel;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Threading.Tasks;

namespace Asp_Identity.Pages
{
    public class LoginModel : PageModel
    {
        private SignInManager<IdentityUser> _signInManger;

        [BindProperty]
        public Login Model { get; set; }

        public LoginModel(SignInManager<IdentityUser> signInManager)
        {
            _signInManger = signInManager;
        }
        public void OnGet()
        {
        }
        public async Task<IActionResult> OnPostAsync()
        {
            if (ModelState.IsValid)
            {
              var user=  await _signInManger.PasswordSignInAsync(Model.Email, Model.Password, Model.RememberMe, false);
                if (user.Succeeded)
                {
                    return RedirectToPage("Index");
                }
                ModelState.AddModelError("", "Credentials did not match");
            }
      

            return Page();
        }
    }
}

