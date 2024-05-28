using DesafioTodoList.Communication.Model;
using DesafioTodoList.Communication.Responses;

namespace DesafioTodoList.Application.UseCase.Task.GetId;

public class GetIdTaskUseCase
{
    public ResponseTaskJson Execute(List<TaskTodo> Db, int id)
    {
        var findTask = Db.FirstOrDefault(task => task.Id == id);

        if (findTask == null)
            return new ResponseTaskJson();

        var response = new ResponseTaskJson
        {
            Id = findTask.Id,
            Name = findTask.Name,
            Deadline = findTask.Deadline,
            Description = findTask.Description,
            Priority = findTask.Priority,
            Status = findTask.Status
        };

        return response;
    }
}