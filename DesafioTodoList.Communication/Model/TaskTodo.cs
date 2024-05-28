using DesafioTodoList.Communication.Enuns;

namespace DesafioTodoList.Communication.Model;

public class TaskTodo
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public Priority Priority { get; set; }
    public DateTime Deadline { get; set; }
    public Status Status { get; set; }
}