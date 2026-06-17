using TaskFlow.Domain.Common;
using TaskFlow.Domain.Enums;

namespace TaskFlow.Domain.Entities;

public class TaskItem : BaseEntity
{
    public string Title { get; set; } = string.Empty;
    public string? Description { get; set; }
    public Priority Priority { get; set; }
    public TaskItemStatus Status { get; set; }
    public DateTime? DueDate { get; set; }

    public Guid ProjectId { get; set; }
    public Project Project { get; set; } = null!;

    private TaskItem() { }  

    public TaskItem(string title, Guid projectId, Priority priority = Priority.Medium)
    {
        Title = title;
        ProjectId = projectId;
        Priority = priority;
        Status = TaskItemStatus.Todo; 
    }
}