using DesafioTodoList.API.Controllers;
using DesafioTodoList.Application.UseCase.Task.Delete;
using DesafioTodoList.Application.UseCase.Task.GetAll;
using DesafioTodoList.Application.UseCase.Task.GetId;
using DesafioTodoList.Application.UseCase.Task.Register;
using DesafioTodoList.Application.UseCase.Task.Update;
using DesafioTodoList.Communication.Requests;
using DesafioTodoList.Communication.Responses;
using Microsoft.AspNetCore.Mvc;

public class TaskController : BaseController
{
    [HttpPost]
    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesResponseType(typeof(ResponseErrorsJson), StatusCodes.Status400BadRequest)]
    public IActionResult Created([FromBody] RequestTaskJson request)
    {
        new RegisterTaskUseCase().Execute(Db, request);

        return Created(string.Empty, string.Empty);
    }

    [HttpGet]
    [ProducesResponseType(typeof(ResponseShortTaskJson), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    public IActionResult GetAll()
    {
        var response = new GetAllTaskUseCase().Execute(Db);

        if (!response.Tasks.Any())
            return NoContent();

        return Ok(response);
    }

    [HttpGet]
    [Route("{id}")]
    [ProducesResponseType(typeof(ResponseTaskJson), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    public IActionResult Get([FromRoute] int id)
    {
        var response = new GetIdTaskUseCase().Execute(Db, id);

        if (string.IsNullOrEmpty(response.Name))
            return NoContent();

        return Ok(response);
    }

    [HttpPut]
    [Route("{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(typeof(ResponseErrorsJson), StatusCodes.Status400BadRequest)]
    [ProducesResponseType(typeof(ResponseErrorsJson), StatusCodes.Status404NotFound)]
    public IActionResult Update([FromRoute] int id, [FromBody] RequestTaskJson request)
    {
        new UpdateTaskUseCase().Execute(Db, id, request);

        return NoContent();
    }

    [HttpDelete]
    [Route("{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(typeof(ResponseErrorsJson), StatusCodes.Status404NotFound)]
    public IActionResult Delete([FromRoute] int id)
    {
        new DeleteTaskUseCase().Execute(Db, id);

        return NoContent();
    }
}