namespace Counter;

internal partial class MainViewModel : ObservableObject
{
    [ObservableProperty] private int _count;

    [ObservableProperty] private int _step = 1;

    [RelayCommand]
    private void Increment()
    {
        Count += Step;
    }
}
