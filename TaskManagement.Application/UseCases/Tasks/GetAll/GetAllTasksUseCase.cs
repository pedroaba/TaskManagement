using TaskManagement.Communication.Responses;

namespace TaskManagement.Application.UseCases.Tasks.GetAll;
public class GetAllTasksUseCase
{
    public ResponseGetAllTasksJson Execute()
    {
        return new ResponseGetAllTasksJson()
        {
            Tasks = []
        };
    }
}
