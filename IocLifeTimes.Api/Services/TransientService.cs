using IocLifeTimes.Api.Interfaces;

namespace IocLifeTimes.Api.Services;

public class TransientService : ITransientGuidService
{
    private readonly Guid _guid;

    public TransientService(Guid guid)
    {
        _guid = guid;
    }

    public Guid GetGuid()
    {
        return _guid;
    }
}
