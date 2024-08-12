using TaskManagement.Communication.Requests;
using TaskManagement.Communication.Responses;

namespace TaskManagement.Application.UseCases.Tasks.Create;
public class CreateTaskUseCase
{
    public ResponseCreateTaskJson Execute(RequestTaskJson request)
    {
        return new ResponseCreateTaskJson() 
        {
            Id = 1,
        };
    }
}
