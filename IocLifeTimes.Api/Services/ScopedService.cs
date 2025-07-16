using IocLifeTimes.Api.Interfaces;

namespace IocLifeTimes.Api.Services;

public class ScopedService : IScopedGuidService
{
    private readonly Guid _guid;

    public ScopedService(Guid guid)
    {
        _guid = guid;
    }

    public Guid GetGuid()
    {
        return _guid;
    }
}
