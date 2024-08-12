using TaskManagement.Communication.Responses;

namespace TaskManagement.Application.UseCases.Tasks.GetById;
public class GetTaskByIdUseCase
{
    public ResponseShortTaskJson Execute(int id)
    {
        return new ResponseShortTaskJson()
        {
            Id = 1,
            Description = "Test",
            Name = "Test",
            Priority = Communication.Enums.TaskPriority.Medium,
            Status = Communication.Enums.TaskStatus.Finished
        };
    }
}
