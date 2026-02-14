using System;
using System.Threading.Tasks;
using Avalonia.Media.Imaging;
using Avalonia.MusicStore.Models;

namespace Avalonia.MusicStore.ViewModels;

public class AlbumViewModel : ViewModelBase, IEquatable<AlbumViewModel>
{
    private readonly Album _album;

    public AlbumViewModel(Album album)
    {
        _album = album;
    }

    public string Artist => _album.Artist;

    public string Title => _album.Title;

    public Task<Bitmap?> Cover => LoadCoverAsync();

    public bool Equals(AlbumViewModel? other)
    {
        if (other is null) return false;
        if (ReferenceEquals(this, other)) return true;
        return _album.Equals(other._album);
    }

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

    public override bool Equals(object? obj)
    {
        if (obj is null) return false;
        if (ReferenceEquals(this, obj)) return true;
        if (obj.GetType() != GetType()) return false;
        return Equals((AlbumViewModel)obj);
    }

    public override int GetHashCode()
    {
        return _album.GetHashCode();
    }
}