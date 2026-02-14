using System.Threading.Tasks;
using Avalonia.Media.Imaging;
using Avalonia.MusicStore.Models;

namespace Avalonia.MusicStore.ViewModels;

public class AlbumViewModel : ViewModelBase
{
    private readonly Album _album;

    public AlbumViewModel(Album album)
    {
        _album = album;
    }

    public string Artist => _album.Artist;

    public string Title => _album.Title;

    public Task<Bitmap?> Cover => LoadCoverAsync();

    // this will be implemented later
    private async Task<Bitmap?> LoadCoverAsync()
    {
        return null;
    }
}