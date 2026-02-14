using Avalonia.MusicStore.ViewModels;
using CommunityToolkit.Mvvm.Messaging.Messages;

namespace Avalonia.MusicStore.Messages;

public class CheckAlbumAlreadyExistsMessage : RequestMessage<bool>
{
    public CheckAlbumAlreadyExistsMessage(AlbumViewModel album)
    {
        Album = album;
    }

    public AlbumViewModel Album { get; }
}