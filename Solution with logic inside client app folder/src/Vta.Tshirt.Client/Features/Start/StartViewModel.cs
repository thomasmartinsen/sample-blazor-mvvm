using Vta.Tshirt.Services;

namespace Vta.Tshirt.Client.Features.Start;

public sealed partial class StartViewModel
{
    private readonly ITshirtService _tshirtService;

    public StartViewModel(ITshirtService tshirtService)
    {
        _tshirtService = tshirtService;
    }

    public StartModel Model { get; set; } = new();

    public async Task LoadDataAsync()
    {
        Model.IsLoading = true;

        try
        {
            await Task.Delay(TimeSpan.FromSeconds(2));
            Model.Entities = await _tshirtService.GetAsync();
        }
        finally
        {
            Model.IsLoading = false;
        }
    }

    public async Task SelectTshirt()
    {
        Model.SelectedTshirt = Model.Entities.First();
        Model.TshirtColor = "blue";
    }
}
