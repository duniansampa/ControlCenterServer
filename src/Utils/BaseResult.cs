﻿namespace ControlCenterServer.Utils;

public class BaseResult<T>
{
    public string Message { get; set; }
    public bool Success { get; set; }
    public T Data { get; set; }
}