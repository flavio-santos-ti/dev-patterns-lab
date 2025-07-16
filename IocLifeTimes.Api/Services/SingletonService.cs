using IocLifeTimes.Api.Interfaces;

namespace IocLifeTimes.Api.Services;

public class SingletonService : ISingletonGuidService
{
    private readonly Guid _guid;

    public SingletonService(Guid guid)
    {
        _guid = guid;
    }

    public Guid GetGuid()
    {
        return _guid;
    }
}
