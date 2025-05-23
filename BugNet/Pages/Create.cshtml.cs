using BugNet.Data;
using BugNet.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BugNet.Pages;

public class Create(BugDbContext context) : PageModel
{
    public string Title { get; set; } = "Create";
    [BindProperty]
    public string Name { get; set; }
    [BindProperty]
    public string Description { get; set; }
    public void OnGet()
    {
        ViewData["Title"] = Title;
    }
    public IActionResult OnPost()
    {
        context.Add(new Bug
        {
            Name = Name,
            Description = Description,
            IsDone = false
        });
        context.SaveChanges();
        return RedirectToPage("Index");
    }
}