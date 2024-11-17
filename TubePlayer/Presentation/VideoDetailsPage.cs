namespace TubePlayer.Presentation;

public sealed partial class VideoDetailsPage : Page
{
    public VideoDetailsPage()
    {
        this.DataContext<VideoDetailsModel>((page, vm) => page
            .Background(Theme.Brushes.Background.Default)
            .Content(new Grid()
                .SafeArea(SafeArea.InsetMask.VisibleBounds)
                .Children(
                    new NavigationBar()
                        .Content("Second Page")
                        .MainCommand(new AppBarButton()
                            .Icon(new BitmapIcon().UriSource(new Uri("ms-appx:///Assets/Images/back.png")))
                        ),
                    new TextBlock()
                        .HorizontalAlignment(HorizontalAlignment.Center)
                        .VerticalAlignment(VerticalAlignment.Center))));
    }
}
