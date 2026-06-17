using TaskFlow.Domain.Common;

namespace TaskFlow.Domain.Entities;

public class Project : BaseEntity
{
    public string Name { get; set; } = string.Empty;
    public string? Description { get; set; }
    public ICollection<TaskItem> TaskItems { get; set; } = new List<TaskItem>();

    private Project() { }

    public Project(string name, string? description = null)
    {
        Name = name;
        Description = description;
    }
}


