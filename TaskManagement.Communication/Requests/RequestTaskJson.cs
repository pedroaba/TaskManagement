using TaskManagement.Communication.Enums;

namespace TaskManagement.Communication.Requests;
public class RequestTaskJson
{
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public TaskPriority Priority { get; set; }
    public Enums.TaskStatus Status { get; set; }
    public DateTime DeadLine { get; set; }
}
