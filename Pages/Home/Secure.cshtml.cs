

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.RazorPages;

[Authorize]
public class SecureModel:PageModel{


    public void OnGet(){
        
    }
}