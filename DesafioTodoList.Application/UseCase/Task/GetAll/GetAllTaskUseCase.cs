using DesafioTodoList.Communication.Model;
using DesafioTodoList.Communication.Responses;

namespace DesafioTodoList.Application.UseCase.Task.GetAll;

public class GetAllTaskUseCase
{
    public ResponseAllTaskJson Execute(List<TaskTodo> Db)
    {
        var response = new ResponseAllTaskJson();

        foreach (TaskTodo item in Db)
        {
            response.Tasks.Add(
                new ResponseShortTaskJson
                {
                    Deadline = item.Deadline,
                    Id = item.Id,
                    Name = item.Name,
                    Priority = item.Priority,
                    Status = item.Status,
                });
        }

        return response;
    }
}