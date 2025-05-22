using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BugNet.Pages;

public class About : PageModel
{
    public string? Message { get; set; }
    public string Title { get; set; } = "About";

    public void OnGet()
    {
        Message = "This is a sample about page" + "  " + DateTime.Now.ToLongTimeString();
        ViewData["Title"] = Title;
    }
}