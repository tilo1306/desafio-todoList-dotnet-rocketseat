using DesafioTodoList.Communication.Model;
using Microsoft.AspNetCore.Mvc;

namespace DesafioTodoList.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class BaseController : ControllerBase
{
    protected static List<TaskTodo> Db = [];
}