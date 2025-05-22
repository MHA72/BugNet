using BugNet.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BugNet.Pages;

public class Index : PageModel
{
    public string Title { get; set; } = "Main";
    
    public IList<Bug>? Bugs { get; set; }
    public int UnDoneCount { get; set; }
    public void OnGet()
    {
        ViewData["Title"] = Title;
        Bugs = new List<Bug>
        {
            new() {Id = 1, Name = "Bug 1", Description = "Bug 1 description", IsDone = false},
            new() {Id = 2, Name = "Bug 2", Description = "Bug 2 description", IsDone = false},
            new() {Id = 3, Name = "Bug 3", Description = "Bug 3 description", IsDone = true},
        };
        UnDoneCount = Bugs.Count(bug => bug.IsDone == false);
    }
}