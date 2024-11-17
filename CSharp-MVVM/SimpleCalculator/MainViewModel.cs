namespace SimpleCalculator;

public partial class MainViewModel : ObservableObject
{
    private readonly IThemeService _themeService;

    [ObservableProperty] private Calculator _calculator = new();

    private bool _isDark;

    public MainViewModel(IThemeService themeService)
    {
        _themeService = themeService;
        IsDark = _themeService.IsDark;
        _themeService.ThemeChanged += (_, _) => IsDark = _themeService.IsDark;
    }

    public bool IsDark
    {
        get => _isDark;
        set
        {
            if (SetProperty(ref _isDark, value))
            {
                _themeService.SetThemeAsync(value ? AppTheme.Dark : AppTheme.Light);
            }
        }
    }

    [RelayCommand]
    private void Input(string key)
    {
        Calculator = Calculator.Input(key);
    }
}
