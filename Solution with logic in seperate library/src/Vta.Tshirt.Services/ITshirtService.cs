using Vta.Tshirt.Services.Entities;

namespace Vta.Tshirt.Services;

public interface ITshirtService
{
    Task<List<TshirtEntity>> GetAsync();
}
