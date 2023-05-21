using System.Windows.Input;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Vta.Tshirt.Services.Entities;

namespace Vta.Tshirt.Client.Logic.Features.Start;

public partial class StartModel : ObservableObject
{
    [ObservableProperty]
    private bool _isLoading = true;

    [ObservableProperty]
    private List<TshirtEntity> _entities = new List<TshirtEntity>();

    [ObservableProperty]
    private TshirtEntity _selectedTshirt = new();

    [ObservableProperty]
    private string _tshirtColor;
}
