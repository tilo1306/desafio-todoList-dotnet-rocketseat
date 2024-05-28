using DesafioTodoList.Communication.Model;
using DesafioTodoList.Communication.Requests;

namespace DesafioTodoList.Application.UseCase.Task.Register;

public class RegisterTaskUseCase
{
    public void Execute(List<TaskTodo> Db, RequestTaskJson request)
    {
        var newTask = new TaskTodo
        {
            Id = Db.Count,
            Name = request.Name,
            Deadline = request.Deadline,
            Description = request.Description,
            Priority = request.Priority,
            Status = request.Status,
        };

        Db.Add(newTask);
    }
}