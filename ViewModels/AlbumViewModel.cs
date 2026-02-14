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

    private async Task<Bitmap?> LoadCoverAsync()
    {
        try
        {
            // We wait a few ms to demonstrate that the images are loaded in the background.
            // Remove this line in production.
            await Task.Delay(200);

            await using (var imageStream = await _album.LoadCoverBitmapAsync())
            {
                return await Task.Run(() => Bitmap.DecodeToWidth(imageStream, 400));
            }
        }
        catch
        {
            return null;
        }
    }
}