using BugNet.Data;
using BugNet.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BugNet.Pages;

public class Index(BugDbContext context) : PageModel
{
    public string Title { get; set; } = "Main";
    
    public IList<Bug>? Bugs { get; set; }
    public int UnDoneCount { get; set; }
    public void OnGet()
    {
        ViewData["Title"] = Title;
        Bugs= context.Bugs.ToList();
        UnDoneCount = Bugs.Count(bug => bug.IsDone == false);
    }
}