# MVVM Pattern

- **Strict Separation**: Keep UI logic in ViewModels. Views should only contain presentation logic.
- **Bindings**: Use compiled bindings (`x:DataType`) in XAML for type safety and performance.
- **Commands**: Use `[RelayCommand]` for actions in ViewModels.
- **Properties**: Use `[ObservableProperty]` for bindable properties to reduce boilerplate.
