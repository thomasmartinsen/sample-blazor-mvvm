using Vta.Tshirt.Services.Entities;

namespace Vta.Tshirt.Services;

public class TshirtService : ITshirtService
{
    public async Task<List<TshirtEntity>> GetAsync()
    {
        await Task.Delay(1000);

        return new List<TshirtEntity>()
        {
            new TshirtEntity() { Id = 1, Size = "M"},
            new TshirtEntity() { Id = 2, Size = "XL"},
            new TshirtEntity() { Id = 3, Size = "L"},
            new TshirtEntity() { Id = 4, Size = "S"},
        };
    }
}
