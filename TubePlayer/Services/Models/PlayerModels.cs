namespace TubePlayer.Services.Models;

public record Format(string? Url, string? QualityLabel);

public record StreamingData(List<Format>? Formats);

public record YoutubeData(StreamingData? StreamingData);
