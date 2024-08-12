﻿using TaskManagement.Communication.Enums;

namespace TaskManagement.Communication.Responses;
public class ResponseShortTaskJson
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public Enums.TaskStatus Status { get; set; }
    public TaskPriority Priority { get; set; }
}
