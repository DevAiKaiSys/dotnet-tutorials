namespace SimpleCalculator;

public partial class MainViewModel : ObservableObject
{
    [ObservableProperty]
    private bool _isDark = false;

    [ObservableProperty]
    private Calculator _calculator = new();

    [RelayCommand]
    private void Input(string key)
    {
        Calculator = Calculator.Input(key);
    }
}
