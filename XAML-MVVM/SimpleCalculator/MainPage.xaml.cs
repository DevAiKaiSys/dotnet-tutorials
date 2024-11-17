namespace SimpleCalculator;

public sealed partial class MainPage : Page
{
    public MainPage()
    {
        InitializeComponent();
        DataContext = new MainViewModel(this.GetThemeService());
    }
}
