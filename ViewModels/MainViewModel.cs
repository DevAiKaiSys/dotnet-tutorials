using System.Threading.Tasks;
using Avalonia.MusicStore.Messages;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.Messaging;

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
        // Send the message to the previously registered handler and await the selected album
        var album = await WeakReferenceMessenger.Default.Send(new PurchaseAlbumMessage());
    }
}