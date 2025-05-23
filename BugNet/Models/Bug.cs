namespace BugNet.Models;

public class Bug
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public bool IsDone { get; set; }
    public bool IsDelete { get; set; } = false;
    public DateTime? DeleteTime { get; set; }
}