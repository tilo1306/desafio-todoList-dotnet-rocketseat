using DesafioTodoList.Communication.Model;

namespace DesafioTodoList.Application.UseCase.Task.Delete;

public class DeleteTaskUseCase
{
    public void Execute(List<TaskTodo> Db, int id)
    {
        var findTask = Db.FirstOrDefault(task => task.Id == id);
        Db.Remove(findTask!);
    }
}