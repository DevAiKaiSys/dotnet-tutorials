using System.Threading.Tasks;
using CommunityToolkit.Mvvm.Input;

namespace Avalonia.MusicStore.ViewModels;

public partial class MainViewModel : ViewModelBase
{
    public MainViewModel()
    {
        // ViewModel initialization logic.
    }
    
    [RelayCommand]
    private async Task AddAlbumAsync()
    {
        // Code here will be executed when the button is clicked.
    }
}