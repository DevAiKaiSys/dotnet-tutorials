using TubePlayer.Business.Models;

namespace TubePlayer.Presentation;

public partial record MainModel(IYoutubeService YoutubeService)
{
    public IState<string> SearchTerm => State<string>.Value(this, () => "Uno Platform");

    public IListFeed<YoutubeVideo> VideoSearchResults => SearchTerm
        .Where(searchTerm => searchTerm is { Length: > 0 })
        .SelectAsync(async (searchTerm, ct) =>
            await YoutubeService.SearchVideos(searchTerm, string.Empty, 30, ct))
        .Select(result => result.Videos)
        .AsListFeed();
}
