using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BugNet.Pages;

public class Index : PageModel
{
    public string Title { get; set; } = "Main";
    public void OnGet()
    {
        ViewData["Title"] = Title;
    }
}