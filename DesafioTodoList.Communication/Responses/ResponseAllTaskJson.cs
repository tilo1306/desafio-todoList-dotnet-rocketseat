﻿namespace DesafioTodoList.Communication.Responses;

public class ResponseAllTaskJson
{
    public List<ResponseShortTaskJson> Tasks { get; set; } = [];
}