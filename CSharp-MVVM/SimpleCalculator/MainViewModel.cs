namespace SimpleCalculator;

public partial class MainViewModel : ObservableObject
{
    [ObservableProperty] private Calculator _calculator = new();

    private bool _isDark;

    public bool IsDark
    {
        get => _isDark;
        set => SetProperty(ref _isDark, value);
    }

    [RelayCommand]
    private void Input(string key)
    {
        Calculator = Calculator.Input(key);
    }
}
