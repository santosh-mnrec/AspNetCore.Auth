

using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;


public class LoginModel : PageModel
{


    [BindProperty]
    public UserDTO UserDTO { get; set; }
    public IActionResult OnGet()
    {
        return Page();
    }

    public async Task OnPost()
    {
        var claims = new List<Claim>
        {
            new Claim(ClaimTypes.Name, UserDTO.Username),
            new Claim("FullName", UserDTO.Password),
            new Claim(ClaimTypes.Role, "Administrator"),
        };

        var claimsIdentity = new ClaimsIdentity(
            claims, CookieAuthenticationDefaults.AuthenticationScheme);
        await HttpContext.SignInAsync(
            CookieAuthenticationDefaults.AuthenticationScheme,
            new ClaimsPrincipal(claimsIdentity));

    }
}