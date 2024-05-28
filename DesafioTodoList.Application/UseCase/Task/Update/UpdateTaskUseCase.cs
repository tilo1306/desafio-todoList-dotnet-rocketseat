using DesafioTodoList.Communication.Model;
using DesafioTodoList.Communication.Requests;

namespace DesafioTodoList.Application.UseCase.Task.Update;

public class UpdateTaskUseCase
{
    public void Execute(List<TaskTodo> Db, int id, RequestTaskJson request)
    {
        var filterTask = Db.FirstOrDefault(t => t.Id == id);

        if (filterTask != null)
        {
            filterTask.Status = request.Status;
            filterTask.Name = request.Name;
            filterTask.Description = request.Description;
            filterTask.Priority = request.Priority;
            filterTask.Deadline = request.Deadline;
        }
    }
}