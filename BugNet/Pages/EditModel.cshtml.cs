using BugNet.Data;
using BugNet.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BugNet.Pages;

public class EditModel(BugDbContext context) : PageModel
{
    public string Title { get; set; } = "Edit";
    [BindProperty]
    public Bug? Bug { get; set; }
    public void OnGet(int id)
    {
        ViewData["Title"] = Title;
        Bug = context.Bugs.FirstOrDefault(b => b.Id == id);
    }
    
    public IActionResult OnPost()
    {
        var bug = context.Bugs.FirstOrDefault(b => b.Id == Bug!.Id);
        bug!.Name = Bug!.Name;
        bug.Description = Bug!.Description;
        bug.IsDone = Bug!.IsDone;
        context.SaveChanges();
        return RedirectToPage("Index");
    }
}