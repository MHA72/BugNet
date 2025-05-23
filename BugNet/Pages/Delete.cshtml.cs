using BugNet.Data;
using BugNet.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BugNet.Pages;

public class Delete(BugDbContext context) : PageModel
{
    public string Title { get; set; } = "Delete";
    [BindProperty]
    public Bug? Bug { get; set; }

    public IActionResult OnGet(int id)
    {
        Bug = context.Bugs.Find(id);
        Bug.IsDelete = true;
        Bug.DeleteTime = DateTime.Now;
        context.Bugs.Update(Bug);
        context.SaveChanges();
        return RedirectToPage("Index");
    }
}