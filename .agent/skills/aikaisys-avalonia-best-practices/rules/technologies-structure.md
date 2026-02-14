# Key Technologies & Project Structure

## Key Technologies
- **Avalonia UI**: Cross-platform XAML framework.
- **CommunityToolkit.Mvvm**: MVVM library (ObservableObject, [ObservableProperty], [RelayCommand]).
- **iTunes Search API**: Used for searching albums.
- **System.Reactive**: Available but prioritize CommunityToolkit for MVVM state.

## Project Structure
- `Views/`: Contains Avalonia UserControls and Windows (.axaml + .axaml.cs).
- `ViewModels/`: Contains ViewModels inheriting `ViewModelBase`.
- `Models/`: Data models used by the app.
- `Assets/`: Images and static resources.
- `ViewLocator.cs`: Maps ViewModels to Views based on naming convention (NameViewModel -> NameView).
