using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Razor4602.Pages;

public class PrivacyModel : PageModel
{
    private readonly ILogger<PrivacyModel> _logger;

    public PrivacyModel(ILogger<PrivacyModel> logger)
    {
        _logger = logger;
    }

    public void OnGet() //read
    {
        ViewData["Name"] = "John Smith";
    }
     public void OnPost() //insert
    {
    }
     public void OnPut() //update
    {
    }
     public void OnDelete() //delete
    {
    }
}

