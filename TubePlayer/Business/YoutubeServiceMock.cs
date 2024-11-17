using TubePlayer.Business.Models;

namespace TubePlayer.Business;

public class YoutubeServiceMock : IYoutubeService
{
    private readonly IDictionary<string, ChannelData> _channels;
    private readonly VideoDetailsResultData _details;

    public YoutubeServiceMock(ISerializer serializer)
    {
        _details = serializer.FromString<VideoDetailsResultData>(YoutubeServiceMockData.DetailsData)!;

        var channelsData = serializer.FromString<ChannelSearchResultData>(YoutubeServiceMockData.ChannelData)!;
        _channels = channelsData.Items!.ToDictionary(channel => channel.Id!, StringComparer.OrdinalIgnoreCase);
    }

    public Task<YoutubeVideoSet> SearchVideos(string searchQuery, string nextPageToken, uint maxResult,
        CancellationToken ct)
    {
        var filtered = _details
            .Items!
            .Where(detail =>
                detail.Snippet!.Title!.Contains(searchQuery, StringComparison.OrdinalIgnoreCase));

        var videos = filtered
            .Select(detail => new YoutubeVideo(_channels[detail.Snippet!.ChannelId!], detail))
            .ToImmutableList();

        var result = new YoutubeVideoSet(videos, string.Empty);

        return Task.FromResult(result);
    }
}
