

using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

public class LogoutModel : PageModel
{

    public async Task<IActionResult> OnPost(string returnUrl = null)
    {
        await HttpContext.SignOutAsync();
        return RedirectToPage("/Home/Index");
    }
}