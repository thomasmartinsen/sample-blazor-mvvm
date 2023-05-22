using Vta.Tshirt.Services.Entities;

namespace Vta.Tshirt.Client.Features.Start;

public class StartModel
{
    public bool IsLoading { get; set; } = true;

    public List<TshirtEntity> Entities { get; set; } = new List<TshirtEntity>();

    public TshirtEntity SelectedTshirt { get; set; } = new();

    public string TshirtColor { get; set; }
}
