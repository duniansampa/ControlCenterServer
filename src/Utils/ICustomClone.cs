namespace ControlCenterServer.Utils;

public interface ICustomClone<T>
{
    T CreateShallowCopy();
}