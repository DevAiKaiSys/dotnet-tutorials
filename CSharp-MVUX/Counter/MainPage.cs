namespace Counter;

public sealed partial class MainPage : Page
{
    public MainPage()
    {
        this.Background(ThemeResource.Get<Brush>("ApplicationPageBackgroundThemeBrush"))
            .Content(
                new StackPanel()
                    .VerticalAlignment(VerticalAlignment.Center)
                    .HorizontalAlignment(HorizontalAlignment.Center)
                    .Children(
                        new Image()
                            .Width(150)
                            .Height(150)
                            .Source("ms-appx:///Assets/logo.png")
                    )
            );
    }
}
