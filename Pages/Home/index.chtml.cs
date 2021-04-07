

using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

public class IndexModel:PageModel{

    public  IActionResult OnGet(){


        return Page();
    }
}